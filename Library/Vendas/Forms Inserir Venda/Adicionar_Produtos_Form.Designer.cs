
namespace Library
{
    partial class Adicionar_Produtos_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_Livro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Procurar_Button = new System.Windows.Forms.Button();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Categorias_Procurar_Livros = new System.Windows.Forms.ComboBox();
            this.Pesquisa_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantidadade_Venda_num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidadade_Venda_num)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Livro
            // 
            this.TextBox_Livro.Location = new System.Drawing.Point(138, 403);
            this.TextBox_Livro.Name = "TextBox_Livro";
            this.TextBox_Livro.Size = new System.Drawing.Size(58, 20);
            this.TextBox_Livro.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID do Livro  Selecionado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Adicionar_button_Click);
            // 
            // Procurar_Button
            // 
            this.Procurar_Button.Location = new System.Drawing.Point(334, 54);
            this.Procurar_Button.Name = "Procurar_Button";
            this.Procurar_Button.Size = new System.Drawing.Size(75, 20);
            this.Procurar_Button.TabIndex = 56;
            this.Procurar_Button.Text = "Procurar";
            this.Procurar_Button.UseVisualStyleBackColor = true;
            this.Procurar_Button.Click += new System.EventHandler(this.Procurar_Button_Click);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(275, 401);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 55;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AllowUserToResizeColumns = false;
            this.Inseridos_Data.AllowUserToResizeRows = false;
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Location = new System.Drawing.Point(13, 87);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(396, 278);
            this.Inseridos_Data.TabIndex = 54;
            this.Inseridos_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inseridos_Data_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Escolha Onde Deseja Procurar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Digite Oque Deseja Procurar";
            // 
            // Categorias_Procurar_Livros
            // 
            this.Categorias_Procurar_Livros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Procurar_Livros.FormattingEnabled = true;
            this.Categorias_Procurar_Livros.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Preço",
            "Ano De Lançamento",
            "Estoque",
            "Páginas"});
            this.Categorias_Procurar_Livros.Location = new System.Drawing.Point(171, 24);
            this.Categorias_Procurar_Livros.Name = "Categorias_Procurar_Livros";
            this.Categorias_Procurar_Livros.Size = new System.Drawing.Size(146, 21);
            this.Categorias_Procurar_Livros.TabIndex = 64;
            // 
            // Pesquisa_TextBox
            // 
            this.Pesquisa_TextBox.Location = new System.Drawing.Point(171, 54);
            this.Pesquisa_TextBox.Name = "Pesquisa_TextBox";
            this.Pesquisa_TextBox.Size = new System.Drawing.Size(146, 20);
            this.Pesquisa_TextBox.TabIndex = 65;
            this.Pesquisa_TextBox.Leave += new System.EventHandler(this.Pesquisa_TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Quantidade";
            // 
            // Quantidadade_Venda_num
            // 
            this.Quantidadade_Venda_num.Location = new System.Drawing.Point(78, 371);
            this.Quantidadade_Venda_num.Name = "Quantidadade_Venda_num";
            this.Quantidadade_Venda_num.Size = new System.Drawing.Size(58, 20);
            this.Quantidadade_Venda_num.TabIndex = 67;
            this.Quantidadade_Venda_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Adicionar_Produtos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 436);
            this.Controls.Add(this.Quantidadade_Venda_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pesquisa_TextBox);
            this.Controls.Add(this.Categorias_Procurar_Livros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_Livro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Procurar_Button);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Inseridos_Data);
            this.MaximizeBox = false;
            this.Name = "Adicionar_Produtos_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantidadade_Venda_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Livro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Procurar_Button;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Categorias_Procurar_Livros;
        private System.Windows.Forms.TextBox Pesquisa_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Quantidadade_Venda_num;
    }
}