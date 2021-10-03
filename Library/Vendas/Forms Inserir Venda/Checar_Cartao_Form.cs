using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Checar_Cartao_Form : Form
    {
        public Checar_Cartao_Form()
        {
            InitializeComponent();
        }

        private Inserir_Venda_Form mainForm = null; //conexao a Form
        public Checar_Cartao_Form(Form callingForm)
        {
            mainForm = callingForm as Inserir_Venda_Form;
            InitializeComponent();
        }

        private void Voltar_Button_Click(object sender, EventArgs e)
        {
            //Ao Clicar em Voltar, a Janela é fechada
            this.Close();
        }

        //variaveis da validação

        bool limite_maximo = false; 
        bool cartão_inexistente = false;
        bool cartão_validado = false;
        string motivo = "";

        public void Validar_button_Click(object sender, EventArgs e)
        {

            // if para verificar se foi digitado algo
            if (Cartao_TextBox.Text == "" || Validade_DatePicker.Text == "" || Cvv_TextBox.Text == "")
            {
                MessageBox.Show("É Preciso Inserir as Informaçoes do Cartão para validar");
            }
            else
            {
                if (Cartao_TextBox.Text.Length < 16 || Cvv_TextBox.Text.Length < 3)
                {
                    MessageBox.Show("Informações Incompletas");
                }
                else
                {
                    Validadação_Cartão();
                    if (cartão_validado == true)
                    {
                        MessageBox.Show("Cartão Validado Com Sucesso");
                        this.mainForm.Validação_Cartão_bool = true; //conexao a Form 
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cartão não foi Validado" + Environment.NewLine + Environment.NewLine + motivo);
                        Cartao_TextBox.Clear();
                        Cvv_TextBox.Clear();
                    }
                }
            }
        }
        private void Validadação_Cartão()
        {
            var rnd = new Random(); //numero aleatorio é gerado para verificação

            int validação = rnd.Next(1, 12);

            if (validação >= 6) //caso seja maior que 6
            {
                int problema = rnd.Next(1, 50);

                if (problema > 30)
                {
                    cartão_inexistente = true;
                    motivo = "O Cartão É Inexistente";
                }
                else
                {
                    if (problema < 10)
                    {
                        limite_maximo = true;
                        motivo = "O Cartão Não tem Limite Suficiente";
                    }
                    else
                    {
                        cartão_validado = true;
                    }
                }

            }
            else
            {
                cartão_validado = true;
            }

        }

        private void Cartao_TextBox_Leave(object sender, EventArgs e)
        {
            Cartao_TextBox.Text = (Cartao_TextBox.Text).Replace(" ", ""); //deixar em estado padrão

            if (Cartao_TextBox.Text != "")
            {
                try //checar se ha Carateres Invalidos no campo
                {
                    long cartao_valor = Convert.ToInt64(Cartao_TextBox.Text);
                    cartao_valor = 0;
                }
                catch
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show("Carateres Invalidos no Número de Cartão");
                    Cartao_TextBox.Clear();
                }
            }
        }

        private void Cvv_TextBox_Leave(object sender, EventArgs e)
        {
            if (Cvv_TextBox.Text != "")
            {
                try //checar se ha Carateres Invalidos no campo
                {
                    int cvv_valor = Convert.ToInt32(Cvv_TextBox.Text);
                    cvv_valor = 0;
                }
                catch
                {
                    // Mostrar Mensagem De Erro
                    MessageBox.Show("Carateres Invalidos no Número de CVV");
                    Cvv_TextBox.Clear();
                }
            }
        }
    }
    
}
