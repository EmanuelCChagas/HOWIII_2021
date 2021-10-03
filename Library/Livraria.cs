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
    public partial class Livraria : Form
    {
        public Livraria()
        {

            InitializeComponent();  //inicalizar Form         
        }
        //  Funcionamento das janelas
        // Ao clicar no botão uma nova janela é aberta e a anterior é escondida até a nova janela ser fechada

        //Livros

        // INSERT
        private void Inserir_Livros_Click(object sender, EventArgs e)
        {
            Inserir_Livro_Form Inserir_Livro_28 = new Inserir_Livro_Form();
            Inserir_Livro_28.Show();  
            //ShowDialog
            this.Hide();
             
        }

        // READ
        private void Verificar_Livros_Click(object sender, EventArgs e)
        {
            Verificar_Livro_Form Verificar_Livro_28 = new Verificar_Livro_Form();
            Verificar_Livro_28.Show();
            this.Hide();
        }

        //UPDATE
        private void Atualizar_Livros_Click(object sender, EventArgs e)
        {
            Atualizar_Livro_Form Atualizar_Livro_28 = new Atualizar_Livro_Form();
            Atualizar_Livro_28.Show();
            this.Hide();
        }

        //DELETE

        private void Deletar_Livros_Click(object sender, EventArgs e)
        {
            Deletar_Livros_Form Deletar_Livro_28 = new Deletar_Livros_Form();
            Deletar_Livro_28.Show();
            this.Hide();
        }

        //Clientes

        // INSERT
        private void Inserir_Clientes_Click(object sender, EventArgs e)
        {
            Inserir_Clientes_Form Inserir_clientes_30 = new Inserir_Clientes_Form();
            Inserir_clientes_30.Show();
            this.Hide();

        }

        // READ
        private void Verificar_Clientes_Click(object sender, EventArgs e)
        {
            Verificar_Clientes_Form Verificar_Clientes_30 = new Verificar_Clientes_Form();
            Verificar_Clientes_30.Show();
            this.Hide();
        }

        //UPDATE
        private void Atualizar_Clientes_Click(object sender, EventArgs e)
        {
            Atualizar_Clientes_Form Atualizar_Clientes_30 = new Atualizar_Clientes_Form();
            Atualizar_Clientes_30.Show();
            this.Hide();
        }

        //DELETE

        private void Deletar_Clientes_Click(object sender, EventArgs e)
        {
            Deletar_Clientes_Form Deletar_Clientes_30 = new Deletar_Clientes_Form();
            Deletar_Clientes_30.Show();
            this.Hide();
        }



        //Vendas


        //Inserir
        private void Inserir_Vendas_Click(object sender, EventArgs e)
        {
            Inserir_Venda_Form Inserir_Venda_Form_30 = new Inserir_Venda_Form();
            Inserir_Venda_Form_30.Show();
            this.Hide();
        }


        //Verificar

        private void Verificar_Vendas_Click(object sender, EventArgs e)
        {
            Verificar_Vendas Verificar_Vendas_1 = new Verificar_Vendas();
            Verificar_Vendas_1.Show();
            this.Hide();
        }

        //Relatório

        private void Relatorio_Vendas_Click(object sender, EventArgs e)
        {
            Relatorio_Vendas Relatorio_Vendas_1 = new Relatorio_Vendas();
            Relatorio_Vendas_1.Show();
            this.Hide();
        }

        // fechamento do Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }

}
