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
    public partial class Verificar_Livro_Form : Form
    {
        public Verificar_Livro_Form()
        {
            InitializeComponent(); //inicalizar Form
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

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            // abaixo a string da tabela sendo procurada
            string sqlSelectAll = "SELECT livro_id AS 'ID',titulo AS 'Título', autor_nome AS 'Autor', preço AS 'Preço', lançamento AS 'Lançamento', paginas AS 'Páginas', estoque AS 'Estoque' from livros WHERE ativo_livro=1  AND " + Column_Read_Livro + " LIKE '%" + Pesquisa_TextBox.Text + "%'; ";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            Verificar_Data.DataSource = bSource;
        }

        private void Verificar_Livro_FormClosing(object sender, FormClosingEventArgs e)
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

       
        private void Procurar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (Pesquisa_TextBox.Text == "" || Categorias_Procurar_Livros.Text =="")
            {
                MessageBox.Show("Você precisa digitar algo para ser procurado");
            }
            else
            {
                ProcurarLivro();
            }
        }

        private void Pesquisa_TextBox_Leave(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
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

