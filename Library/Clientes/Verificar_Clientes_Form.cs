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
    public partial class Verificar_Clientes_Form : Form
    {
        public Verificar_Clientes_Form()
        {
            InitializeComponent(); //inicalizar Form
        }
        private void ProcurarCliente()
        {

            // é utilizado um SWITCH para verificar a Tabela que será Procurada
            string Categoria_Procurar_Clientes_Txt = Categorias_Procurar_Clientes.Text;
            string Column_Read_Clientes = "";
            String Data_Replace = ""; //Variavel para dar Replace DATA
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
            if( Column_Read_Clientes == "Data_Criação_Usuario" )
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

        private void Verificar_Clientes_FormClosing(object sender, FormClosingEventArgs e)
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
            if (Pesquisa_TextBox.Text == "" || Categorias_Procurar_Clientes.Text =="")
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
    }
}
