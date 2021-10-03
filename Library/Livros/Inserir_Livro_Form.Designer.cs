
namespace Library
{
    partial class Inserir_Livro_Form
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
            this.Titulo_Label = new System.Windows.Forms.Label();
            this.Titulo_Box = new System.Windows.Forms.TextBox();
            this.Nome_Autor_Label = new System.Windows.Forms.Label();
            this.Nome_Autor_Box = new System.Windows.Forms.TextBox();
            this.Lançamento_Label = new System.Windows.Forms.Label();
            this.Lançamento_Picker = new System.Windows.Forms.DateTimePicker();
            this.Estoque_Label = new System.Windows.Forms.Label();
            this.Estoque_Num = new System.Windows.Forms.NumericUpDown();
            this.Paginas_Label = new System.Windows.Forms.Label();
            this.Pages_Num = new System.Windows.Forms.NumericUpDown();
            this.Enviar_Button = new System.Windows.Forms.Button();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Preço_Num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Estoque_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pages_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preço_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo_Label
            // 
            this.Titulo_Label.AutoSize = true;
            this.Titulo_Label.Location = new System.Drawing.Point(34, 28);
            this.Titulo_Label.Name = "Titulo_Label";
            this.Titulo_Label.Size = new System.Drawing.Size(35, 13);
            this.Titulo_Label.TabIndex = 0;
            this.Titulo_Label.Text = "Título";
            // 
            // Titulo_Box
            // 
            this.Titulo_Box.Location = new System.Drawing.Point(75, 25);
            this.Titulo_Box.Name = "Titulo_Box";
            this.Titulo_Box.Size = new System.Drawing.Size(184, 20);
            this.Titulo_Box.TabIndex = 1;
            // 
            // Nome_Autor_Label
            // 
            this.Nome_Autor_Label.AutoSize = true;
            this.Nome_Autor_Label.Location = new System.Drawing.Point(270, 28);
            this.Nome_Autor_Label.Name = "Nome_Autor_Label";
            this.Nome_Autor_Label.Size = new System.Drawing.Size(78, 13);
            this.Nome_Autor_Label.TabIndex = 2;
            this.Nome_Autor_Label.Text = "Nome do Autor";
            // 
            // Nome_Autor_Box
            // 
            this.Nome_Autor_Box.Location = new System.Drawing.Point(354, 25);
            this.Nome_Autor_Box.Name = "Nome_Autor_Box";
            this.Nome_Autor_Box.Size = new System.Drawing.Size(156, 20);
            this.Nome_Autor_Box.TabIndex = 3;
            // 
            // Lançamento_Label
            // 
            this.Lançamento_Label.AutoSize = true;
            this.Lançamento_Label.Location = new System.Drawing.Point(525, 28);
            this.Lançamento_Label.Name = "Lançamento_Label";
            this.Lançamento_Label.Size = new System.Drawing.Size(66, 13);
            this.Lançamento_Label.TabIndex = 4;
            this.Lançamento_Label.Text = "Lançamento";
            // 
            // Lançamento_Picker
            // 
            this.Lançamento_Picker.CustomFormat = "yyyy";
            this.Lançamento_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Lançamento_Picker.Location = new System.Drawing.Point(597, 28);
            this.Lançamento_Picker.Name = "Lançamento_Picker";
            this.Lançamento_Picker.ShowUpDown = true;
            this.Lançamento_Picker.Size = new System.Drawing.Size(59, 20);
            this.Lançamento_Picker.TabIndex = 5;
            this.Lançamento_Picker.Value = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            // 
            // Estoque_Label
            // 
            this.Estoque_Label.AutoSize = true;
            this.Estoque_Label.Location = new System.Drawing.Point(270, 70);
            this.Estoque_Label.Name = "Estoque_Label";
            this.Estoque_Label.Size = new System.Drawing.Size(46, 13);
            this.Estoque_Label.TabIndex = 6;
            this.Estoque_Label.Text = "Estoque";
            // 
            // Estoque_Num
            // 
            this.Estoque_Num.Location = new System.Drawing.Point(354, 68);
            this.Estoque_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Estoque_Num.Name = "Estoque_Num";
            this.Estoque_Num.Size = new System.Drawing.Size(55, 20);
            this.Estoque_Num.TabIndex = 7;
            // 
            // Paginas_Label
            // 
            this.Paginas_Label.AutoSize = true;
            this.Paginas_Label.Location = new System.Drawing.Point(525, 70);
            this.Paginas_Label.Name = "Paginas_Label";
            this.Paginas_Label.Size = new System.Drawing.Size(45, 13);
            this.Paginas_Label.TabIndex = 8;
            this.Paginas_Label.Text = "Páginas";
            // 
            // Pages_Num
            // 
            this.Pages_Num.Location = new System.Drawing.Point(597, 70);
            this.Pages_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Pages_Num.Name = "Pages_Num";
            this.Pages_Num.Size = new System.Drawing.Size(59, 20);
            this.Pages_Num.TabIndex = 9;
            // 
            // Enviar_Button
            // 
            this.Enviar_Button.Location = new System.Drawing.Point(758, 475);
            this.Enviar_Button.Name = "Enviar_Button";
            this.Enviar_Button.Size = new System.Drawing.Size(75, 23);
            this.Enviar_Button.TabIndex = 10;
            this.Enviar_Button.Text = "Enviar";
            this.Enviar_Button.UseVisualStyleBackColor = true;
            this.Enviar_Button.Click += new System.EventHandler(this.Enviar_Button_Click);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(663, 475);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 11;
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
            this.Inseridos_Data.Location = new System.Drawing.Point(37, 123);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.ReadOnly = true;
            this.Inseridos_Data.RowHeadersWidth = 60;
            this.Inseridos_Data.Size = new System.Drawing.Size(778, 326);
            this.Inseridos_Data.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Preço";
            // 
            // Preço_Num
            // 
            this.Preço_Num.DecimalPlaces = 2;
            this.Preço_Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Preço_Num.Location = new System.Drawing.Point(79, 69);
            this.Preço_Num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Preço_Num.Name = "Preço_Num";
            this.Preço_Num.Size = new System.Drawing.Size(97, 20);
            this.Preço_Num.TabIndex = 14;
            // 
            // Inserir_Livro_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.Preço_Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseridos_Data);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Enviar_Button);
            this.Controls.Add(this.Pages_Num);
            this.Controls.Add(this.Paginas_Label);
            this.Controls.Add(this.Estoque_Num);
            this.Controls.Add(this.Estoque_Label);
            this.Controls.Add(this.Lançamento_Picker);
            this.Controls.Add(this.Lançamento_Label);
            this.Controls.Add(this.Nome_Autor_Box);
            this.Controls.Add(this.Nome_Autor_Label);
            this.Controls.Add(this.Titulo_Box);
            this.Controls.Add(this.Titulo_Label);
            this.MaximizeBox = false;
            this.Name = "Inserir_Livro_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inserir_Livro_FormClosing);
            this.Load += new System.EventHandler(this.Inserir_Livro_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Estoque_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pages_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Preço_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_Label;
        private System.Windows.Forms.TextBox Titulo_Box;
        private System.Windows.Forms.Label Nome_Autor_Label;
        private System.Windows.Forms.TextBox Nome_Autor_Box;
        private System.Windows.Forms.Label Lançamento_Label;
        private System.Windows.Forms.DateTimePicker Lançamento_Picker;
        private System.Windows.Forms.Label Estoque_Label;
        private System.Windows.Forms.NumericUpDown Estoque_Num;
        private System.Windows.Forms.Label Paginas_Label;
        private System.Windows.Forms.NumericUpDown Pages_Num;
        private System.Windows.Forms.Button Enviar_Button;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Preço_Num;
    }
}