
namespace Library
{
    partial class Verificar_Vendas
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
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.Categorias_Procurar_Vendas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Procurar_Button = new System.Windows.Forms.Button();
            this.Digite_Label = new System.Windows.Forms.Label();
            this.Pesquisa_TextBox = new System.Windows.Forms.TextBox();
            this.Voltar_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AllowUserToResizeColumns = false;
            this.Inseridos_Data.AllowUserToResizeRows = false;
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Location = new System.Drawing.Point(22, 99);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(778, 326);
            this.Inseridos_Data.TabIndex = 47;
            // 
            // Categorias_Procurar_Vendas
            // 
            this.Categorias_Procurar_Vendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Procurar_Vendas.FormattingEnabled = true;
            this.Categorias_Procurar_Vendas.Items.AddRange(new object[] {
            "Cliente",
            "Titulo do Livro",
            "Data"});
            this.Categorias_Procurar_Vendas.Location = new System.Drawing.Point(191, 17);
            this.Categorias_Procurar_Vendas.Name = "Categorias_Procurar_Vendas";
            this.Categorias_Procurar_Vendas.Size = new System.Drawing.Size(146, 21);
            this.Categorias_Procurar_Vendas.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Escolha Onde Deseja Procurar";
            // 
            // Procurar_Button
            // 
            this.Procurar_Button.Location = new System.Drawing.Point(753, 453);
            this.Procurar_Button.Name = "Procurar_Button";
            this.Procurar_Button.Size = new System.Drawing.Size(75, 23);
            this.Procurar_Button.TabIndex = 44;
            this.Procurar_Button.Text = "Procurar";
            this.Procurar_Button.UseVisualStyleBackColor = true;
            this.Procurar_Button.Click += new System.EventHandler(this.Procurar_Button_Click);
            // 
            // Digite_Label
            // 
            this.Digite_Label.AutoSize = true;
            this.Digite_Label.Location = new System.Drawing.Point(19, 44);
            this.Digite_Label.Name = "Digite_Label";
            this.Digite_Label.Size = new System.Drawing.Size(142, 13);
            this.Digite_Label.TabIndex = 43;
            this.Digite_Label.Text = "Digite Oque Deseja Procurar";
            // 
            // Pesquisa_TextBox
            // 
            this.Pesquisa_TextBox.Location = new System.Drawing.Point(191, 44);
            this.Pesquisa_TextBox.Name = "Pesquisa_TextBox";
            this.Pesquisa_TextBox.Size = new System.Drawing.Size(414, 20);
            this.Pesquisa_TextBox.TabIndex = 42;
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(658, 453);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 41;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Verificar_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 485);
            this.Controls.Add(this.Inseridos_Data);
            this.Controls.Add(this.Categorias_Procurar_Vendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Procurar_Button);
            this.Controls.Add(this.Digite_Label);
            this.Controls.Add(this.Pesquisa_TextBox);
            this.Controls.Add(this.Voltar_Button);
            this.MaximizeBox = false;
            this.Name = "Verificar_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio_Vendas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.ComboBox Categorias_Procurar_Vendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Procurar_Button;
        private System.Windows.Forms.Label Digite_Label;
        private System.Windows.Forms.TextBox Pesquisa_TextBox;
        private System.Windows.Forms.Button Voltar_Button;
    }
}