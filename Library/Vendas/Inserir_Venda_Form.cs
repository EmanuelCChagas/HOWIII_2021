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
    public partial class Inserir_Venda_Form : Form
    {
        public Inserir_Venda_Form()
        {
            InitializeComponent(); //inicialização do form
        }

        private void Inserir_Livro_Form_Load(object sender, EventArgs e)
        {
            atualizaGrid(); //cada vez que a form carrega o DataGridView atualiza
        }

        // Ao Fechar Mostra o Form do Menu
        private void Inserir_Venda_FormClosing(object sender, FormClosingEventArgs e)
        {

            Livraria Form1 = new Livraria();
            Form1.Show();
        }

        private void Enviar_Button_Click(object sender, EventArgs e)
        { 
            // if para verificar se foi digitado algo
            if (TexBox_Valor_Total.Text == "" || Id_Cliente_TextBox.Text == "" || Categoria_Pagamento.Text == "")
            {
                MessageBox.Show("Não Foi Possivel Completar a Venda. As Informações estão incompletas.");
            }
            else
            { 
                if(valido == false && Categoria_Pagamento.Text == "Cartão de Crédito")
                {
                    MessageBox.Show("O Cartão não esta valido");
                }
                else
                {
                    Insert_Venda_DB();
                    this.Close();
                }
                
            }
        
            
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            //Ao Clicar em Voltar, a Janela é fechada
            this.Close();
        }



             // Escolher Cliente
        private void Escolher_Cliente_Click(object sender, EventArgs e)
        {
            Adicionar_Cliente_Venda Adicionar_Cliente_Venda_10 = new Adicionar_Cliente_Venda(this);
            Adicionar_Cliente_Venda_10.ShowDialog();
  
        }
        public string Cliente_Venda_Con     //conexao a janela de inserção de cliente
        {

            get { return Id_Cliente_TextBox.Text; }
            set { Id_Cliente_TextBox.Text = value; }
        }


        private void Inserir_Venda_Form_Enter(object sender, EventArgs e)
        {
            atualizaGrid(); //ao entrar no form atualiza o grid e calcula valor total
            Valor_Total_Calc();
        }

        // Adicionar Livro ao Caixa

        private void Adicionar_Livro_Button_Click(object sender, EventArgs e)
        {
            Adicionar_Produtos_Form Adicionar_Produtos_Form_113 = new Adicionar_Produtos_Form(this);
            Adicionar_Produtos_Form_113.ShowDialog();
        }


        // Escolher Produto

        //variaveis globais para inserção
        string Livro_Inf = ""; //informaçoes do livro
        string Livro_quant = ""; //quantidade do livro
        public string Livro_Venda_Con     //conexao a janela de inserção de livro e pegar informações do livro
        {
            
            get { return Livro_Inf; }
            set { Livro_Inf = value; }
        }

        public string Livro_Quantidade    //conexao a janela de inserção de livro e pegar informações de quantidade
        {

            get { return Livro_quant; }
            set { Livro_quant = value; }
        }
        private void atualizaGrid() //Pegar Dados do Livro especificado no Banco de Dados
        {  
            if(Livro_Inf != "") //caso livro tenha sido inserido
            {               
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;"; //dados do Banco de Dados
                                                                                                                                        
                string query = "SELECT * from livros WHERE ativo_livro = 1 AND livro_id = " + Livro_Inf + "; "; //encontra na base de dados, os dados do livro escolhido

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    //coloca os dados encontrados do livro na DataGridView
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    myReader.Read();
                    DataGridViewRow row = (DataGridViewRow)Inseridos_Data.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = myReader.GetString("titulo");
                    row.Cells[1].Value = myReader.GetString("autor_nome");
                    row.Cells[2].Value = myReader.GetString("preço");
                    row.Cells[3].Value = Livro_quant;
                    row.Cells[5].Value = Livro_Inf;
                    Inseridos_Data.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                    myReader.Close(); 
                    databaseConnection.Close();
                    Livro_Inf = ""; //zera o valor de informaçoes do livro para nova inserção
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        //EXCLUIR Produto

        private void Excluir_Livro_Button_Click(object sender, EventArgs e)
        {
            if (Inseridos_Data.Rows.Count > 0) {
                foreach (DataGridViewCell oneCell in Inseridos_Data.SelectedCells)
                {
                    if (oneCell.Selected)
                        try
                        {
                           if (oneCell.RowIndex == 3)
                            {
                                desconto = 0; //caso seja a quarta fileira o desconto sera feito novamente
                            }

                            Inseridos_Data.Rows.RemoveAt(oneCell.RowIndex);
                            Valor_Total_Calc();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                }
            }
        }
        private void Inseridos_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Inseridos_Data.CurrentRow.Index != -1)
                {
                    string exclusão = Inseridos_Data.CurrentRow.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Calcular Valor Total

        int desconto = 0; //variavel para desconto
        private void Valor_Total_Calc()
        {
            if (Inseridos_Data.Rows.Count > 1)
            {            
                try
                {
                    //pegando numero de row na conta
                    int Num_Row = Inseridos_Data.Rows.Count;
                    Num_Row = Num_Row - 1;

                    //passar valor unitario para valor total
                    for (int contagem_valor = 0; contagem_valor < Num_Row; contagem_valor++)
                    {
                        decimal soma_valor_un = Convert.ToDecimal(Inseridos_Data.Rows[contagem_valor].Cells[2].Value);
                        decimal soma_quant = Convert.ToDecimal(Inseridos_Data.Rows[contagem_valor].Cells[3].Value);
                        decimal soma_valor_total = soma_valor_un * soma_quant;
                        Inseridos_Data.Rows[contagem_valor].Cells[4].Value = soma_valor_total;
                    }

                    //Caso hajá mais de 3 livros o quarto tem 20% de descontos
                    if (Num_Row >= 4)
                    {
                        while (desconto == 0)
                        {
                            // desconto de 20% no quarto livro utlizando regra de 3
                            decimal valor_original = Convert.ToDecimal(Inseridos_Data.Rows[3].Cells[2].Value);
                            decimal desconto_calc = Convert.ToDecimal(Inseridos_Data.Rows[3].Cells[2].Value);
                            desconto_calc = desconto_calc * 20; 
                            desconto_calc = desconto_calc / 100;
                            desconto_calc = Math.Round(desconto_calc, 2);
                            Inseridos_Data.Rows[3].Cells[2].Value = valor_original - desconto_calc;
                            decimal soma_valor_desc = Convert.ToDecimal(Inseridos_Data.Rows[3].Cells[2].Value);
                            decimal soma_quant_desc = Convert.ToDecimal(Inseridos_Data.Rows[3].Cells[3].Value);
                            Inseridos_Data.Rows[3].Cells[4].Value = soma_valor_desc * soma_quant_desc;
                            desconto++;
                        }

                    }
                    //criando array para pegar os valores do row
                    string[] array_soma = new string[Num_Row];
                    for (int somando = 0; somando < Num_Row; somando++)
                    {
                        string valor_soma = Convert.ToString(Inseridos_Data.Rows[somando].Cells[4].Value);
                        array_soma[somando] = valor_soma;
                    }
                    //fazer um array para transformar esses valores em decimal
                    decimal[] array_itens = new decimal[array_soma.Length];
                    for (int i = 0; i < array_soma.Length; i++)
                    {
                        array_itens[i] = Convert.ToDecimal(array_soma[i]);
                    }
                    //somar valores
                    decimal soma_decimal_valor = 0;
                    for (int soma_total = 0; soma_total < array_soma.Length; soma_total++)
                    {
                        soma_decimal_valor += array_itens[soma_total];
                    }

                    //passar para caixa de texto
                    TexBox_Valor_Total.Text = Convert.ToString(soma_decimal_valor);

                    //trocar virgula por ponto para inserção na base de dados
                    try
                    {                   
                        TexBox_Valor_Total.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:#,##0.00}", double.Parse(TexBox_Valor_Total.Text));
                        TexBox_Valor_Total.Text = (TexBox_Valor_Total.Text).Replace(",", "");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void Insert_Venda_DB()
        {
            string Categoria_Pagamento_st = Categoria_Pagamento.Text; // string para pesquisa banco de dados

            //conexao
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bookstore_db;SslMode=None;"; //dados do Banco de Dados
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            //primeira query Inserir na tabela vendas

            string query = "INSERT INTO vendas(`Valor_total`,`Pagamento_Forma`, `cliente_venda_id`) VALUES ('" + TexBox_Valor_Total.Text + "','" + Categoria_Pagamento_st + "','" + Id_Cliente_TextBox.Text + "');";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                     MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Venda Concluida com Sucesso.");
                databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }


            //pegar id de Vendas
            string Venda_Id_info = "";
             query = "SELECT @@IDENTITY AS 'Identity'; ";
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                Venda_Id_info= commandDatabase.ExecuteScalar().ToString();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar Mensagem De Erro
                MessageBox.Show(ex.Message);
            }


            //pegando numero de row na conta
            int Num_Row = Inseridos_Data.Rows.Count;
            Num_Row = Num_Row - 1;

            //inserir informações da venda na tabela vendas_info
            for (int contagem_inserção = 0; contagem_inserção < Num_Row; contagem_inserção++)
            {
                query = "INSERT INTO vendas_info(`cliente_venda_info_id`,`livro_venda_info_id`, `valor_unit`,`quantidade`,`venda_total_id`) VALUES ('" + Id_Cliente_TextBox.Text + "','" + Inseridos_Data.Rows[contagem_inserção].Cells[5].Value + "','" + Inseridos_Data.Rows[contagem_inserção].Cells[2].Value + "','" + Inseridos_Data.Rows[contagem_inserção].Cells[3].Value + "','" + Venda_Id_info + "');";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                    //Venda_Id_info = ""; //zerando variaveis para futuras interações
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }
            }

            for (int contagem_update = 0; contagem_update < Num_Row; contagem_update++)
            {
                //dar update nos estoque dos livros que foram vendidos
                query = "UPDATE livros SET estoque =(SELECT estoque from livros WHERE livro_id="+ Inseridos_Data.Rows[contagem_update].Cells[5].Value + ")-"+ Inseridos_Data.Rows[contagem_update].Cells[3].Value + "  WHERE livro_id =" + Inseridos_Data.Rows[contagem_update].Cells[5].Value + ";";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //validação cartão de crédito
        private void Checar_Cartão()
        {
            Checar_Cartao_Form Checar_Cartao_Form_1 = new Checar_Cartao_Form(this);
            Checar_Cartao_Form_1.ShowDialog();
        }

        bool valido = false; //variavel para validação de cartão

        public bool Validação_Cartão_bool    //conexao a janela de validação
        {
            get { return valido; }
            set { valido = value; }
        }
        private void Inserir_Venda_Form_MouseHover(object sender, EventArgs e)
        {
            Valor_Total_Calc();  //para se certificar que o valor total será calculado mesmo se o usuário não clicar em nada        
        }


        private void Categoria_Pagamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Categoria_Pagamento.Text == "Cartão de Crédito") // se cartão de crédito for selecionado, checar se está valido
            {
                Checar_Cartão();
            }
        }
    }
    
}
