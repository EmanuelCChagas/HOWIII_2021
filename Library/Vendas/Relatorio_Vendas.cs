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
    public partial class Relatorio_Vendas : Form
    {
        public Relatorio_Vendas()
        {
            InitializeComponent();
        }

        private void Relatorio_Vendas_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Pesquisar_Button_Click(object sender, EventArgs e)
        {
            // if para verificar se foi digitado algo
            if (Categorias_Pesquisar_Vendas.Text == "")
            {
                MessageBox.Show("Você precisa digitar o mês para a pesquisa ser feita");
            }
            else
            {
                Fazer_Relatorio();
            }
        }
        private void Fazer_Relatorio()
        {
            // é utilizado um SWITCH para verificar o mês que será Procurado
            string Categoria_Procurar_mes_Txt = Categorias_Pesquisar_Vendas.Text;
            string Column_Read_mes = "";
            switch (Categoria_Procurar_mes_Txt) // passar mes para ingles para pesquisa no banco de dados
            {
                case "Janeiro":
                    Column_Read_mes = "January";
                    break;
                case "Fevereiro":
                    Column_Read_mes = "February";
                    break;
                case "Março":
                    Column_Read_mes = "March";
                    break;
                case "Abril":
                    Column_Read_mes = "April";
                    break;
                case "Maio":
                    Column_Read_mes = "May";
                    break;
                case "Junho":
                    Column_Read_mes = "June";
                    break;
                case "Julho":
                    Column_Read_mes = "July";
                    break;
                case "Agosto":
                    Column_Read_mes = "August";
                    break;
                case "Setembro":
                    Column_Read_mes = "September";
                    break;
                case "Outubro":
                    Column_Read_mes = "October";
                    break;
                case "Novembro":
                    Column_Read_mes = "November";
                    break;
                case "Dezembro":
                    Column_Read_mes = "December";
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
            string sqlSelectAll = "select  livro_venda_info_id AS 'ID do Livro',titulo AS 'Titulo do Livro',Count(livro_venda_info_id) AS 'Vendas no Mês',valor_unit AS 'Valor Unitário',sum(valor_unit)'Valor Total em Vendas' from vendas,vendas_info,livros WHERE venda_id=venda_total_id  AND MONTHNAME(venda_data)='" + Column_Read_mes + "' AND livro_venda_info_id=livro_id group by livro_venda_info_id order by sum(valor_unit) desc ;";
           MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

            DataTable table = new DataTable();
            MyDA.Fill(table); 
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            Verificar_Data.DataSource = bSource;          
        }
    }
}
