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
using System.Net.Mail;

namespace Library
{
    public partial class Inserir_Clientes_Form : Form
    {
        public Inserir_Clientes_Form()
        {
            InitializeComponent(); //inicialização do form       
        }

        private void Inserir_Clientes_Form_Load(object sender, EventArgs e)
        {
            MySQL_ToDatagridview_CL(); //ao carregar atualiza o DATAGRIDVIEW
        }
        
        private void Inserir_Clientes_FormClosing(object sender, FormClosingEventArgs e)
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
        private void SalvarClientes() //Salva CLientes no Banco de Dados
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;"; //dados do Banco de Dados
            string query = "INSERT INTO clientes(`Nome`,`Email`,`Telefone`) VALUES ('" + Nome_Cliente_Box.Text + "','" + Email_Clientes_TextBox.Text + "','" + Telefone_Clientes_MaskedTextBox.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cliente Registrado com Sucesso.");
                MySQL_ToDatagridview_CL();

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
            if (Nome_Cliente_Box.Text == "" || Email_Clientes_TextBox.Text == "" || Telefone_Clientes_MaskedTextBox.Text == "")
            {
                MessageBox.Show("Você precisa digitar as informações do Cliente para que seja incluido");
            }
            else
            {

                //validação de telefone
                if (Telefone_Clientes_MaskedTextBox.Text.Length < 13)
                {
                    MessageBox.Show("O Numero de Telefone está Incorreto.");
                }
                else
                {
                    SalvarClientes();
                    //limpar 
                    Nome_Cliente_Box.Text = String.Empty;
                    Email_Clientes_TextBox.Text = String.Empty;
                    Telefone_Clientes_MaskedTextBox.Text = String.Empty;
                }           
            }
        }

        private void Email_Clientes_TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                //verificação de email
                MailAddress ma = new MailAddress(Email_Clientes_TextBox.Text);
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show("Digite um Email Valido");
            }
        }

        private void Telefone_Clientes_MaskedTextBox_Leave(object sender, EventArgs e)
        {        
            //Aviso para numero de telefone
            if (Telefone_Clientes_MaskedTextBox.Text.Length < 13)
            {
                MessageBox.Show("O Numero de Telefone está Incorreto." + Environment.NewLine + "O Número de telefone deverá Conter o Código de Área e o Número 9.");
            }
        }
    }
}
