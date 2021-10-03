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

namespace Library
{
    public partial class Adicionar_Produtos_Form : Form
    {
        public Adicionar_Produtos_Form()
        {
            InitializeComponent();
        }

        private Inserir_Venda_Form mainForm = null; //conexao a Form
        public Adicionar_Produtos_Form(Form callingForm)
        {
            mainForm = callingForm as Inserir_Venda_Form;
            InitializeComponent();
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            //Ao Clicar em Voltar, a Janela é fechada
            this.Close();
        }

        //pesquisa
        private void Procurar_Button_Click(object sender, EventArgs e)
        {
            if (Categorias_Procurar_Livros.Text == "" || Pesquisa_TextBox.Text == "")
            {
                MessageBox.Show("Você precisa digitar algo para Pesquisar");
            }
            else
            {
                ProcurarLivro();
            }
        }

        private void ProcurarLivro()
        {
            // é utilizado um SWITCH para verificar a Tabela que será Procurada
            string Categoria_Procurar_Livro_Txt = Categorias_Procurar_Livros.Text;
            string Column_Read_Livro = "";
            switch (Categoria_Procurar_Livro_Txt)
            {
                case "Título":
                    Column_Read_Livro = "titulo";
                    break;
                case "Autor":
                    Column_Read_Livro = "autor_nome";
                    break;

                case "Preço":
                    Column_Read_Livro = "preço";
                    break;
                case "Ano De Lançamento":
                    Column_Read_Livro = "lançamento";
                    break;
                case "Estoque":
                    Column_Read_Livro = "estoque";
                    break;
                case "Páginas":
                    Column_Read_Livro = "paginas";
                    break;
                default:
                    break;
            }

            // Conexão ao banco de dados para verificar
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                // abaixo a string da tabela sendo procurada
                string sqlSelectAll = "SELECT livro_id AS 'ID',titulo AS 'Título', autor_nome AS 'Autor', preço AS 'Preço', lançamento AS 'Lançamento', paginas AS 'Páginas', estoque AS 'Estoque' from livros WHERE ativo_livro=1  AND " + Column_Read_Livro + " LIKE '%" + Pesquisa_TextBox.Text + "%'; ";
                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                Inseridos_Data.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //inclusao
        public void Adicionar_button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (TextBox_Livro.Text == "")
            {
                MessageBox.Show("Um Livro precisa ser selecionado");
            }
            else
            {
                    this.mainForm.Livro_Venda_Con = TextBox_Livro.Text; //conexao a Form 
                    this.mainForm.Livro_Quantidade = Quantidadade_Venda_num.Text;
                    this.Close(); 
            }
        }



        private void Inseridos_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Inseridos_Data.CurrentRow.Index != -1)
                {

                    TextBox_Livro.Text = Inseridos_Data.CurrentRow.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Pesquisa_TextBox_Leave(object sender, EventArgs e)
        {
            if (Pesquisa_TextBox.Text == "")
            {
            }
            else
            {
                if (Categorias_Procurar_Livros.Text == "Preço")
                {
                    try
                    {
                        //trocar virgula por ponto
                        Pesquisa_TextBox.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:#,##0.00}", double.Parse(Pesquisa_TextBox.Text));
                        Pesquisa_TextBox.Text = (Pesquisa_TextBox.Text).Replace(",", "");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
    }
}
