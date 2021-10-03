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
    public partial class Inserir_Livro_Form : Form
    {
        public Inserir_Livro_Form()
        {
            InitializeComponent(); //inicialização do form
        }

        private void Inserir_Livro_Form_Load(object sender, EventArgs e)
        {       
            MySQL_ToDatagridview(); //ao carregar atualiza o DATAGRIDVIEW
        }
        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            //Ao Clicar em Voltar, a Janela é fechada
            this.Close();
        }

        private void MySQL_ToDatagridview() // Mostra Dados do MYSQL no DATAGRIDVIEW
        {
           
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT livro_id AS 'ID',titulo AS 'Título', autor_nome AS 'Autor', preço AS 'Preço', lançamento AS 'Lançamento', paginas AS 'Páginas', estoque AS 'Estoque' from livros WHERE ativo_livro=1 ";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            Inseridos_Data.DataSource = bSource;

            DataGridViewColumn  titulo_coluna = Inseridos_Data.Columns[1]; //aumentar tamanho da coluna titulo
            titulo_coluna.Width = 150;
        }
        // Ao Fechar Mostra o Form do Menu
        private void Inserir_Livro_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Livraria Form1 = new Livraria(); 
            Form1.Show();
        }
        private void SalvarLivro() //Salva Livros no Banco de Dados
        {
            // transforma a inserção de "," para "."
            //por nao ser string essa snippet é mais adequado para evitar bugs na transformação de decimal a string e vice versa
            // a snippet abaixo muda a config do sistema para "."
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

           //conexao
           string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;"; //dados do Banco de Dados
            string query = "INSERT INTO livros(`titulo`,`autor_nome`,`lançamento`,`estoque`, `paginas`, `preço`) VALUES ('" + Titulo_Box.Text + "', '" + Nome_Autor_Box.Text + "', '" + Lançamento_Picker.Value.ToString("yyyy-MM-dd") + "', '" + Estoque_Num.Value + "', '" + Pages_Num.Value + "','" + Preço_Num.Value + "')";
            
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            // a snippet abaixo volta o sistema ao padraão "," para inserção de novos dados
            System.Globalization.CultureInfo customCulture1 = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture1.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture1;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Livro Registrado com Sucesso.");
                MySQL_ToDatagridview();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }

        private void Enviar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (Titulo_Box.Text == "" || Nome_Autor_Box.Text == "" )
            {
                MessageBox.Show("Você precisa digitar as informações do livro para que seja incluido");
            }
            else
            {
                SalvarLivro();
                //limpar 
                Titulo_Box.Text = String.Empty;
                Nome_Autor_Box.Text = String.Empty;
                Lançamento_Picker.Format = DateTimePickerFormat.Custom;
                Preço_Num.Text = "";
                Estoque_Num.Text = "";
                Pages_Num.Text = "";
            }

        }
    }
}
