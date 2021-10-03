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
    public partial class Atualizar_Clientes_Form : Form
    {
        public Atualizar_Clientes_Form()
        {
            InitializeComponent(); //inicialização do form
        }

        private void Atualizar_Clientes_Form_Load(object sender, EventArgs e)
        {
            MySQL_ToDatagridview_CL(); //ao carregar atualiza o DATAGRIDVIEW
        }

        private void Atualizar_Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ao Fechar Mostra o Form do Menu
            Livraria Form1 = new Livraria();
            Form1.Show();
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


        private void AtualizarClientes() //Da o Update de Clientes no Banco de Dados
        {
            //variavel para checar o Email
            int Confirm = 1;
            if (Categorias_Atualizar_Clientes.Text == "Email" )
            {
                try
                {
                    //verificação de email
                    MailAddress ma = new MailAddress(Att_Label.Text);
                }
                catch 
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show("Digite um Email Valido");
                    Confirm = 0;

                }
            }
            //se Email for Confirmado
            if (Confirm == 1)
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;";
                // abaixo a string da tabela sendo modificada
                string query = "UPDATE clientes SET " + Categorias_Atualizar_Clientes.Text + " = '" + Att_Label.Text + "' WHERE cliente_id =" + TextBox_Cliente_ID.Text + "; ";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();

                    MessageBox.Show("Cliente Atualizado com Sucesso.");
                    MySQL_ToDatagridview_CL();

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }
            }
            


        }
        private void Inseridos_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        //selecionar livro para dar update 
        {
            try
            {
                if (Inseridos_Data.CurrentRow.Index != -1)
                {

                    TextBox_Cliente_ID.Text = Inseridos_Data.CurrentRow.Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Atualizar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (Categorias_Atualizar_Clientes.Text == "" || Att_Label.Text == "" || TextBox_Cliente_ID.Text == "")
            {
                MessageBox.Show("Você precisa digitar as informações do Cliente para que seja incluido");
            }
            else
            {
               AtualizarClientes();
                //limpar 
                Categorias_Atualizar_Clientes.Text = String.Empty;
                Att_Label.Text = String.Empty;
                TextBox_Cliente_ID.Text = String.Empty;
            }
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            //Ao Clicar em Voltar, a Janela é fechada
            this.Close();
        }     
    }
}
