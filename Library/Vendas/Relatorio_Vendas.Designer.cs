
namespace Library
{
    partial class Relatorio_Vendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Categorias_Pesquisar_Vendas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Verificar_Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Verificar_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolher Mês";
            // 
            // Categorias_Pesquisar_Vendas
            // 
            this.Categorias_Pesquisar_Vendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Pesquisar_Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorias_Pesquisar_Vendas.FormattingEnabled = true;
            this.Categorias_Pesquisar_Vendas.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.Categorias_Pesquisar_Vendas.Location = new System.Drawing.Point(170, 49);
            this.Categorias_Pesquisar_Vendas.Name = "Categorias_Pesquisar_Vendas";
            this.Categorias_Pesquisar_Vendas.Size = new System.Drawing.Size(146, 28);
            this.Categorias_Pesquisar_Vendas.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 34;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Pesquisar_Button_Click);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(688, 468);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(123, 30);
            this.Voltar_Button.TabIndex = 36;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Livros Mais Vendidos no Mês";
            // 
            // Verificar_Data
            // 
            this.Verificar_Data.AllowUserToResizeColumns = false;
            this.Verificar_Data.AllowUserToResizeRows = false;
            this.Verificar_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Verificar_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Verificar_Data.Location = new System.Drawing.Point(38, 97);
            this.Verificar_Data.Name = "Verificar_Data";
            this.Verificar_Data.Size = new System.Drawing.Size(773, 326);
            this.Verificar_Data.TabIndex = 42;
            // 
            // Relatorio_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.Verificar_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Categorias_Pesquisar_Vendas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Relatorio_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio das Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio_Vendas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Verificar_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Categorias_Pesquisar_Vendas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Verificar_Data;
    }
}