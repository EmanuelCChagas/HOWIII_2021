using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace Library
{
    public partial class Atualizar_Livro_Form : Form
    {
        public Atualizar_Livro_Form()
        {
            InitializeComponent(); //inicialização do form
        }
        private void Atualizar_Livro_Form_Load(object sender, EventArgs e)
        {
            MySQL_ToDatagridview();  //ao carregar atualiza o DATAGRIDVIEW
        }
        private void MySQL_ToDatagridview() // Mostra Dados do MYSQL no DATAGRIDVIEW
        {

            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT livro_id AS 'ID',titulo AS 'Título', autor_nome AS 'Autor', preço AS 'Preço', lançamento AS 'Lançamento', paginas AS 'Páginas', estoque AS 'Estoque' from livros WHERE ativo_livro=1";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            Inseridos_Data.DataSource = bSource;
        }

        private void Inseridos_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        //selecionar livro para dar update 
        {
            try
            {
                if (Inseridos_Data.CurrentRow.Index != -1)
                {

                    TextBox_Livro_ID.Text = Inseridos_Data.CurrentRow.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Atualizar_Livro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ao Fechar Mostra o Form do Menu
            Livraria Form1 = new Livraria();
            Form1.Show();
        }
        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            //Ao Clicar em Voltar, a Janela é fechada
            this.Close();
        }
        private void Atualizar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (Att_Label.Text == "" || Categorias_Atualizar_Livros.Text =="")
            {
                MessageBox.Show("Você precisa digitar algo para ser dar a atualização");
            }
            else
            {
                if (TextBox_Livro_ID.Text == "") {
                    MessageBox.Show("Você precisa selecionar algo para ser atualizado");
                }
                else
                {
                    //AO Atualizar, a DATAGRIDVIEW é ATUALIZADA
                    AtualizarLivro();
                    MySQL_ToDatagridview();
                    //limpar pesquisa
                    Att_Label.Text = String.Empty;
                    TextBox_Livro_ID.Text = String.Empty;
                }
            }
        }
        private void AtualizarLivro() //Da o Update de Livros no Banco de Dados
        {
            //nesse caso é melhor converter virgula para ponto na switch do preço manualmente
            //uso de variavel para o switch do preço
            string Update_ATT_Label = Att_Label.Text;

            // é utilizado um SWITCH para verificar a Tabela que será modificada
            string Categoria_Livro_Txt = Categorias_Atualizar_Livros.Text;
            string Column_Update_Livro= "";
            switch (Categoria_Livro_Txt) 
            {
                case "Título":
                    Column_Update_Livro = "titulo";
                    break;
                case "Autor":
                    Column_Update_Livro = "autor_nome";                
                    break;
                case "Preço":
                    Column_Update_Livro = "preço";
                    //Converter "," para "."
                    try
                    {
                        decimal Resultado_Preço_1 = Convert.ToDecimal(Att_Label.Text);
                        string Resultado_Preço_2 = Resultado_Preço_1.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));
                        Update_ATT_Label = Resultado_Preço_2;
                    }
                    catch (Exception ex)
                    {
                        // Mostrar Mensagem De Erro
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case "Ano De Lançamento":
                    Column_Update_Livro = "lançamento";
                    break;
            case "Estoque":
                    Column_Update_Livro = "estoque";
                    break;
            case "Páginas":
                    Column_Update_Livro = "paginas";
                    break;
             default:           
                    break;
            }

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;";
            // abaixo a string da tabela sendo modificada
            string query = "UPDATE livros SET " + Column_Update_Livro + " = '" + Update_ATT_Label + "' WHERE livro_id =" + TextBox_Livro_ID.Text + "; ";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Livro Atualizado com Sucesso.");
                MySQL_ToDatagridview();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }


        }

    }
}
