
namespace Library
{
    partial class Adicionar_Cliente_Venda
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
            this.Categorias_Procurar_Clientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Digite_Label = new System.Windows.Forms.Label();
            this.Pesquisa_TextBox = new System.Windows.Forms.TextBox();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.Procurar_Button = new System.Windows.Forms.Button();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_Clientes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Categorias_Procurar_Clientes
            // 
            this.Categorias_Procurar_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Procurar_Clientes.FormattingEnabled = true;
            this.Categorias_Procurar_Clientes.Items.AddRange(new object[] {
            "Nome",
            "Telefone",
            "Email",
            "Data de Criação"});
            this.Categorias_Procurar_Clientes.Location = new System.Drawing.Point(184, 18);
            this.Categorias_Procurar_Clientes.Name = "Categorias_Procurar_Clientes";
            this.Categorias_Procurar_Clientes.Size = new System.Drawing.Size(131, 21);
            this.Categorias_Procurar_Clientes.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Escolha Onde Deseja Procurar";
            // 
            // Digite_Label
            // 
            this.Digite_Label.AutoSize = true;
            this.Digite_Label.Location = new System.Drawing.Point(12, 45);
            this.Digite_Label.Name = "Digite_Label";
            this.Digite_Label.Size = new System.Drawing.Size(142, 13);
            this.Digite_Label.TabIndex = 41;
            this.Digite_Label.Text = "Digite Oque Deseja Procurar";
            // 
            // Pesquisa_TextBox
            // 
            this.Pesquisa_TextBox.Location = new System.Drawing.Point(184, 45);
            this.Pesquisa_TextBox.Name = "Pesquisa_TextBox";
            this.Pesquisa_TextBox.Size = new System.Drawing.Size(131, 20);
            this.Pesquisa_TextBox.TabIndex = 40;
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AllowUserToResizeColumns = false;
            this.Inseridos_Data.AllowUserToResizeRows = false;
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Location = new System.Drawing.Point(15, 88);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(396, 278);
            this.Inseridos_Data.TabIndex = 44;
            this.Inseridos_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inseridos_Data_CellClick);
            // 
            // Procurar_Button
            // 
            this.Procurar_Button.Location = new System.Drawing.Point(336, 45);
            this.Procurar_Button.Name = "Procurar_Button";
            this.Procurar_Button.Size = new System.Drawing.Size(75, 23);
            this.Procurar_Button.TabIndex = 46;
            this.Procurar_Button.Text = "Procurar";
            this.Procurar_Button.UseVisualStyleBackColor = true;
            this.Procurar_Button.Click += new System.EventHandler(this.Procurar_Button_Click);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(284, 401);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 45;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Adicionar_button_Click);
            // 
            // TextBox_Clientes
            // 
            this.TextBox_Clientes.Location = new System.Drawing.Point(96, 398);
            this.TextBox_Clientes.Name = "TextBox_Clientes";
            this.TextBox_Clientes.Size = new System.Drawing.Size(58, 20);
            this.TextBox_Clientes.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "ID selecionado";
            // 
            // Adicionar_Cliente_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 436);
            this.Controls.Add(this.TextBox_Clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Procurar_Button);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Inseridos_Data);
            this.Controls.Add(this.Categorias_Procurar_Clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Digite_Label);
            this.Controls.Add(this.Pesquisa_TextBox);
            this.MaximizeBox = false;
            this.Name = "Adicionar_Cliente_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente para Venda";
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Categorias_Procurar_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Digite_Label;
        private System.Windows.Forms.TextBox Pesquisa_TextBox;
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.Button Procurar_Button;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_Clientes;
        private System.Windows.Forms.Label label2;
    }
}