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
    public partial class Deletar_Clientes_Form : Form
    {
        public Deletar_Clientes_Form()
        {
            InitializeComponent();
        }
        private void Deletar_Clientes_Form_Load(object sender, EventArgs e)
        {
            MySQL_ToDatagridview_CL();
        }
        private void Deletar_Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ao fechar mostra o form do menu
            Livraria Form1 = new Livraria();
            Form1.Show();
        }
        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MySQL_ToDatagridview_CL() // Mostra Dados do MYSQL no DATAGRIDVIEW
        {

            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT cliente_id AS 'ID', Nome, Email, Telefone, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente = 1; ";

            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            Inseridos_Data.DataSource = bSource;
        }
        private void Deletar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (TextBox_Clientes_Deletar.Text == "")
            {
                MessageBox.Show("Você precisa escolher algo para ser deletado");
            }
            else
            {
                DeletarClientes();
                MySQL_ToDatagridview_CL();
            }
        }
        private void ProcurarCliente()
        {
            // é utilizado um SWITCH para verificar a Tabela que será Procurada
            string Categoria_Procurar_Clientes_Txt = Categorias_Procurar_Clientes.Text;
            string Column_Read_Clientes = "";
            String Data_Replace = ""; //Variavel para dar Replace
            switch (Categoria_Procurar_Clientes_Txt)
            {
                case "Nome":
                    Column_Read_Clientes = "Nome";
                    break;
                case "Telefone":
                    Column_Read_Clientes = "Telefone";
                    break;
                case "Email":
                    Column_Read_Clientes = "Email";
                    break;
                case "Data de Criação":
                    Column_Read_Clientes = "Data_Criação_Usuario";
                    //modificar dados para pesquisa de DATA
                    Data_Replace = (Pesquisa_TextBox.Text).Replace("/", " ");
                    Data_Replace = (Data_Replace).Replace("-", " ");
                    break;
                default:
                    break;
            }

            // Conexão ao banco de dados para verificar
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            //inicio da variavel para a Query
            string sqlSelectAll = "";
            // if para mudar a QUERY MYSQL para a de DATA
            if (Column_Read_Clientes == "Data_Criação_Usuario")
            {
                // abaixo a string da tabela sendo procurada
                sqlSelectAll = "SELECT cliente_id AS 'ID', Nome, Email, Telefone, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente = 1  AND " + Column_Read_Clientes + " =  STR_TO_DATE('" + Data_Replace + "', '%d %m %Y');";

            }
            else
            {
                // abaixo a string da tabela sendo procurada
                sqlSelectAll = "SELECT cliente_id AS 'ID', Nome, Email, Telefone, Data_Criação_Usuario AS 'Criado em' FROM clientes WHERE ativo_cliente=1  AND " + Column_Read_Clientes + " LIKE '%" + Pesquisa_TextBox.Text + "%'; ";

            }

            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            Inseridos_Data.DataSource = bSource;
        }

        private void Procurar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (Pesquisa_TextBox.Text == "" || Categorias_Procurar_Clientes.Text == "")
            {
                MessageBox.Show("Você precisa digitar algo para ser procurado");
            }
            else
            {
                //Validação Telefone
                if (Categorias_Procurar_Clientes.Text == "Telefone" && Pesquisa_TextBox.Text.Length < 13)
                {
                    MessageBox.Show("O Numero de Telefone está Incorreto." + Environment.NewLine + "O Número de telefone deverá estar no formato __-_____-____Conter o Código de Área e o Número 9.");
                }
                else
                {
                    ProcurarCliente();
                }
            }
        }

        private void DeletarClientes() //"Deleta" Livros no Banco de Dados
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;"; //dados do Banco de Dados
            // da Update Onde o Ativo do livro fica 0 e ele fica desativo no Banco de Dados
            string query = "UPDATE clientes SET ativo_cliente = 0 WHERE cliente_id = " + TextBox_Clientes_Deletar.Text + "; ";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cliente Deletado com Sucesso.");
                MySQL_ToDatagridview_CL();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
            //limpar pesquisa
            Pesquisa_TextBox.Text = String.Empty;
            TextBox_Clientes_Deletar.Text = String.Empty;

        }

        private void Inseridos_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        //selecionar livro para deletar
        {
            try
            {
                if (Inseridos_Data.CurrentRow.Index != -1)
                {

                    TextBox_Clientes_Deletar.Text = Inseridos_Data.CurrentRow.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
