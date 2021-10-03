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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        string Validação_Login_string = "FALSE"; //string pra validação

        private void button1_Click(object sender, EventArgs e)
        {
            if (senha_textbox.Text == "" || login_textbox.Text == "")
            {
                MessageBox.Show("Digite o Login ou a Senha corretamente.");
            }
            else
            {
                validação_login();
                if (Validação_Login_string == "FALSE")
                {
                    MessageBox.Show("Usuario ou Senha incorretos");
                }
                else
                {
                    //inicia o form correto
                    Livraria Livraria_entrar = new Livraria();
                    this.Hide();
                    Livraria_entrar.Show();                
                }
            }
        }
        private void validação_login()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;"; //dados do Banco de Dados
                                                                                                                                  
            string query = "SELECT IF((SELECT senha from login WHERE senha =" + senha_textbox.Text + " AND usuario='" + login_textbox.Text + "') IS NOT NULL, 'TRUE', 'FALSE') FROM login;";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                Validação_Login_string = commandDatabase.ExecuteScalar().ToString();
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
