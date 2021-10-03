
namespace Library
{
    partial class Verificar_Livro_Form
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
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.Pesquisa_TextBox = new System.Windows.Forms.TextBox();
            this.Digite_Label = new System.Windows.Forms.Label();
            this.Procurar_Button = new System.Windows.Forms.Button();
            this.Categorias_Procurar_Livros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Verificar_Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Verificar_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(656, 497);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 1;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Pesquisa_TextBox
            // 
            this.Pesquisa_TextBox.Location = new System.Drawing.Point(209, 63);
            this.Pesquisa_TextBox.Name = "Pesquisa_TextBox";
            this.Pesquisa_TextBox.Size = new System.Drawing.Size(414, 20);
            this.Pesquisa_TextBox.TabIndex = 2;
            this.Pesquisa_TextBox.Leave += new System.EventHandler(this.Pesquisa_TextBox_Leave);
            // 
            // Digite_Label
            // 
            this.Digite_Label.AutoSize = true;
            this.Digite_Label.Location = new System.Drawing.Point(35, 66);
            this.Digite_Label.Name = "Digite_Label";
            this.Digite_Label.Size = new System.Drawing.Size(142, 13);
            this.Digite_Label.TabIndex = 3;
            this.Digite_Label.Text = "Digite Oque Deseja Procurar";
            // 
            // Procurar_Button
            // 
            this.Procurar_Button.Location = new System.Drawing.Point(751, 497);
            this.Procurar_Button.Name = "Procurar_Button";
            this.Procurar_Button.Size = new System.Drawing.Size(75, 23);
            this.Procurar_Button.TabIndex = 4;
            this.Procurar_Button.Text = "Procurar";
            this.Procurar_Button.UseVisualStyleBackColor = true;
            this.Procurar_Button.Click += new System.EventHandler(this.Procurar_Button_Click);
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
            this.Categorias_Procurar_Livros.Location = new System.Drawing.Point(209, 30);
            this.Categorias_Procurar_Livros.Name = "Categorias_Procurar_Livros";
            this.Categorias_Procurar_Livros.Size = new System.Drawing.Size(146, 21);
            this.Categorias_Procurar_Livros.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Escolha Onde Deseja Procurar";
            // 
            // Verificar_Data
            // 
            this.Verificar_Data.AllowUserToResizeColumns = false;
            this.Verificar_Data.AllowUserToResizeRows = false;
            this.Verificar_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Verificar_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Verificar_Data.Location = new System.Drawing.Point(27, 129);
            this.Verificar_Data.Name = "Verificar_Data";
            this.Verificar_Data.Size = new System.Drawing.Size(778, 326);
            this.Verificar_Data.TabIndex = 41;
            // 
            // Verificar_Livro_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 532);
            this.Controls.Add(this.Verificar_Data);
            this.Controls.Add(this.Categorias_Procurar_Livros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Procurar_Button);
            this.Controls.Add(this.Digite_Label);
            this.Controls.Add(this.Pesquisa_TextBox);
            this.Controls.Add(this.Voltar_Button);
            this.MaximizeBox = false;
            this.Name = "Verificar_Livro_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verificar_Livro_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Verificar_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.TextBox Pesquisa_TextBox;
        private System.Windows.Forms.Label Digite_Label;
        private System.Windows.Forms.Button Procurar_Button;
        private System.Windows.Forms.ComboBox Categorias_Procurar_Livros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Verificar_Data;
    }
}