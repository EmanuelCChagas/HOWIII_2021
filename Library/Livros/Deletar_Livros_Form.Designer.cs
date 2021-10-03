
namespace Library
{
    partial class Deletar_Livros_Form
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_Livros_Deletar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.Categorias_Procurar_Livros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Digite_Label = new System.Windows.Forms.Label();
            this.Pesquisa_TextBox = new System.Windows.Forms.TextBox();
            this.Procurar_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deletar_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // TextBox_Livros_Deletar
            // 
            this.TextBox_Livros_Deletar.Location = new System.Drawing.Point(235, 110);
            this.TextBox_Livros_Deletar.Name = "TextBox_Livros_Deletar";
            this.TextBox_Livros_Deletar.Size = new System.Drawing.Size(86, 20);
            this.TextBox_Livros_Deletar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o ID do Livro para Deletar";
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Location = new System.Drawing.Point(32, 147);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.ReadOnly = true;
            this.Inseridos_Data.Size = new System.Drawing.Size(788, 310);
            this.Inseridos_Data.TabIndex = 5;
            this.Inseridos_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inseridos_Data_CellClick);
            // 
            // Categorias_Procurar_Livros
            // 
            this.Categorias_Procurar_Livros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Procurar_Livros.FormattingEnabled = true;
            this.Categorias_Procurar_Livros.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Categorias_Procurar_Livros.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Preço",
            "Ano De Lançamento",
            "Estoque",
            "Páginas"});
            this.Categorias_Procurar_Livros.Location = new System.Drawing.Point(235, 45);
            this.Categorias_Procurar_Livros.Name = "Categorias_Procurar_Livros";
            this.Categorias_Procurar_Livros.Size = new System.Drawing.Size(146, 21);
            this.Categorias_Procurar_Livros.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Escolha O Campo para Fazer a Pesquisa";
            // 
            // Digite_Label
            // 
            this.Digite_Label.AutoSize = true;
            this.Digite_Label.Location = new System.Drawing.Point(29, 79);
            this.Digite_Label.Name = "Digite_Label";
            this.Digite_Label.Size = new System.Drawing.Size(148, 13);
            this.Digite_Label.TabIndex = 34;
            this.Digite_Label.Text = "Digite Oque Deseja Pesquisar";
            // 
            // Pesquisa_TextBox
            // 
            this.Pesquisa_TextBox.Location = new System.Drawing.Point(235, 73);
            this.Pesquisa_TextBox.Name = "Pesquisa_TextBox";
            this.Pesquisa_TextBox.Size = new System.Drawing.Size(320, 20);
            this.Pesquisa_TextBox.TabIndex = 33;
            this.Pesquisa_TextBox.Leave += new System.EventHandler(this.Pesquisa_TextBox_Leave);
            // 
            // Procurar_Button
            // 
            this.Procurar_Button.Location = new System.Drawing.Point(598, 73);
            this.Procurar_Button.Name = "Procurar_Button";
            this.Procurar_Button.Size = new System.Drawing.Size(75, 23);
            this.Procurar_Button.TabIndex = 37;
            this.Procurar_Button.Text = "Procurar";
            this.Procurar_Button.UseVisualStyleBackColor = true;
            this.Procurar_Button.Click += new System.EventHandler(this.Procurar_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Encontre O Livro para Deletar";
            // 
            // Deletar_Livros_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 512);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Procurar_Button);
            this.Controls.Add(this.Categorias_Procurar_Livros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Digite_Label);
            this.Controls.Add(this.Pesquisa_TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_Livros_Deletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseridos_Data);
            this.MaximizeBox = false;
            this.Name = "Deletar_Livros_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deletar_Livros_FormClosing);
            this.Load += new System.EventHandler(this.Deletar_Livros_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_Livros_Deletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.ComboBox Categorias_Procurar_Livros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Digite_Label;
        private System.Windows.Forms.TextBox Pesquisa_TextBox;
        private System.Windows.Forms.Button Procurar_Button;
        private System.Windows.Forms.Label label3;
    }
}