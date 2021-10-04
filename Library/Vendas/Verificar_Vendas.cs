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
    public partial class Verificar_Vendas : Form
    {
        public Verificar_Vendas()
        {
            InitializeComponent();
            MySQL_ToDatagridview_Venda();
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
        private void MySQL_ToDatagridview_Venda() // Mostra Dados do MYSQL no DATAGRIDVIEW
        {
            try
            {
                MySqlConnection mysqlCon = new

                MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
                mysqlCon.Open();

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sqlSelectAll = "select venda_id AS 'ID de Venda',cliente_venda_info_id AS 'Cliente ID',nome AS 'Cliente', Pagamento_Forma AS 'Forma de Pagamento', DATE_FORMAT(venda_data,'%d/%m/%Y') AS 'Data',venda_info_id AS 'ID venda individual',livro_venda_info_id AS 'ID do Livro', titulo AS 'Titulo do Livro',quantidade,valor_unit AS 'Valor Unitário', Valor_total AS 'Valor Total da Venda' from vendas,vendas_info,clientes,livros WHERE venda_id=venda_total_id AND cliente_venda_info_id=cliente_id AND livro_venda_info_id=livro_id group by venda_info_id order by venda_id desc,venda_info_id desc  ;";

                MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, mysqlCon);

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                Inseridos_Data.DataSource = bSource;
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcurarVenda()
        {

            // é utilizado um SWITCH para verificar a Tabela que será Procurada
            string Categorias_Procurar_Vendas_Txt = Categorias_Procurar_Vendas.Text;
            string Column_Read_Vendas = "";
            String Data_Replace = ""; //Variavel para dar Replace DATA
            string sqlSelectAll = "";  //inicio da variavel para a Query
            switch (Categorias_Procurar_Vendas_Txt)
            {
                case "Cliente":
                    Column_Read_Vendas = "Cliente";
                    sqlSelectAll = "select venda_id AS 'ID de Venda',cliente_venda_info_id AS 'Cliente_ID',nome AS 'Cliente', Pagamento_Forma AS 'Forma de Pagamento', DATE_FORMAT(venda_data,'%d/%m/%Y') AS 'Data',venda_info_id AS 'ID venda individual',livro_venda_info_id AS 'ID do Livro', titulo AS 'Titulo do Livro',quantidade,valor_unit AS 'Valor Unitário', Valor_total AS 'Valor Total da Venda' from vendas,vendas_info,clientes,livros WHERE venda_id=venda_total_id AND cliente_venda_info_id=cliente_id AND livro_venda_info_id=livro_id AND Nome LIKE '%" + Pesquisa_TextBox.Text +"%' group by venda_info_id order by venda_id desc,venda_info_id desc  ;";
                    break;
                case "Titulo do Livro":
                    Column_Read_Vendas = "Titulo";
                    sqlSelectAll = "select venda_id AS 'ID de Venda',cliente_venda_info_id AS 'Cliente_ID',nome AS 'Cliente', Pagamento_Forma AS 'Forma de Pagamento', DATE_FORMAT(venda_data,'%d/%m/%Y') AS 'Data',venda_info_id AS 'ID venda individual',livro_venda_info_id AS 'ID do Livro', titulo AS 'Titulo do Livro',quantidade,valor_unit AS 'Valor Unitário', Valor_total AS 'Valor Total da Venda' from vendas,vendas_info,clientes,livros WHERE venda_id=venda_total_id AND cliente_venda_info_id=cliente_id AND livro_venda_info_id=livro_id AND titulo LIKE '%" + Pesquisa_TextBox.Text + "%' group by venda_info_id order by venda_id desc,venda_info_id desc  ;";
                    break;
                case "Data":
                    Column_Read_Vendas = "Data";
                    //modificar dados para pesquisa de DATA
                    Data_Replace = (Pesquisa_TextBox.Text).Replace("/", " ");
                    Data_Replace = (Data_Replace).Replace("-", " ");
                    sqlSelectAll = "select venda_id AS 'ID de Venda',cliente_venda_info_id AS 'Cliente_ID',nome AS 'Cliente', Pagamento_Forma AS 'Forma de Pagamento', DATE_FORMAT(venda_data,'%d/%m/%Y') AS 'Data',venda_info_id AS 'ID venda individual',livro_venda_info_id AS 'ID do Livro', titulo AS 'Titulo do Livro',quantidade,valor_unit AS 'Valor Unitário', Valor_total AS 'Valor Total da Venda' from vendas,vendas_info,clientes,livros WHERE venda_id=venda_total_id AND cliente_venda_info_id=cliente_id AND livro_venda_info_id=livro_id AND  venda_data= STR_TO_DATE('" + Data_Replace + "', '%d %m %Y') group by venda_info_id order by venda_id desc,venda_info_id desc  ;";
                    Console.WriteLine(sqlSelectAll);
                    Console.ReadLine();
                    break;
                default:
                    break;
            }

            // Conexão ao banco de dados para verificar
            MySqlConnection mysqlCon = new

            MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;convert zero datetime=True");
            mysqlCon.Open();
            MySqlDataAdapter MyDA = new MySqlDataAdapter();       
            // if para mudar a QUERY MYSQL para a de DATA
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
            if (Pesquisa_TextBox.Text == "" || Categorias_Procurar_Vendas.Text == "")
            {
                MessageBox.Show("Você precisa digitar algo para ser procurado");
            }
            else
            {
                //Validação Telefone
                if (Categorias_Procurar_Vendas.Text == "Telefone" && Pesquisa_TextBox.Text.Length < 13)
                {
                    MessageBox.Show("O Numero de Telefone está Incorreto." + Environment.NewLine + "O Número de telefone deverá estar no formato __-_____-____Conter o Código de Área e o Número 9.");
                }
                else
                {
                    ProcurarVenda();
                }
            }
        }
    }
}
