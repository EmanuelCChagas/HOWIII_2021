
namespace Library
{
    partial class Deletar_Clientes_Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.Procurar_Button = new System.Windows.Forms.Button();
            this.Categorias_Procurar_Clientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Digite_Label = new System.Windows.Forms.Label();
            this.Pesquisa_TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox_Clientes_Deletar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Encontre O Cliente para Deletar";
            // 
            // Procurar_Button
            // 
            this.Procurar_Button.Location = new System.Drawing.Point(590, 75);
            this.Procurar_Button.Name = "Procurar_Button";
            this.Procurar_Button.Size = new System.Drawing.Size(75, 23);
            this.Procurar_Button.TabIndex = 48;
            this.Procurar_Button.Text = "Procurar";
            this.Procurar_Button.UseVisualStyleBackColor = true;
            this.Procurar_Button.Click += new System.EventHandler(this.Procurar_Button_Click);
            // 
            // Categorias_Procurar_Clientes
            // 
            this.Categorias_Procurar_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Procurar_Clientes.FormattingEnabled = true;
            this.Categorias_Procurar_Clientes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Categorias_Procurar_Clientes.Items.AddRange(new object[] {
            "Nome",
            "Telefone",
            "Email",
            "Data de Criação"});
            this.Categorias_Procurar_Clientes.Location = new System.Drawing.Point(227, 47);
            this.Categorias_Procurar_Clientes.Name = "Categorias_Procurar_Clientes";
            this.Categorias_Procurar_Clientes.Size = new System.Drawing.Size(146, 21);
            this.Categorias_Procurar_Clientes.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Escolha O Campo para Fazer a Pesquisa";
            // 
            // Digite_Label
            // 
            this.Digite_Label.AutoSize = true;
            this.Digite_Label.Location = new System.Drawing.Point(21, 81);
            this.Digite_Label.Name = "Digite_Label";
            this.Digite_Label.Size = new System.Drawing.Size(148, 13);
            this.Digite_Label.TabIndex = 45;
            this.Digite_Label.Text = "Digite Oque Deseja Pesquisar";
            // 
            // Pesquisa_TextBox
            // 
            this.Pesquisa_TextBox.Location = new System.Drawing.Point(227, 75);
            this.Pesquisa_TextBox.Name = "Pesquisa_TextBox";
            this.Pesquisa_TextBox.Size = new System.Drawing.Size(320, 20);
            this.Pesquisa_TextBox.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(758, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deletar_Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // TextBox_Clientes_Deletar
            // 
            this.TextBox_Clientes_Deletar.Location = new System.Drawing.Point(227, 112);
            this.TextBox_Clientes_Deletar.Name = "TextBox_Clientes_Deletar";
            this.TextBox_Clientes_Deletar.Size = new System.Drawing.Size(86, 20);
            this.TextBox_Clientes_Deletar.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Selecione o ID do Cliente para Deletar";
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Location = new System.Drawing.Point(24, 149);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(788, 310);
            this.Inseridos_Data.TabIndex = 39;
            this.Inseridos_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inseridos_Data_CellClick);
            // 
            // Deletar_Clientes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Procurar_Button);
            this.Controls.Add(this.Categorias_Procurar_Clientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Digite_Label);
            this.Controls.Add(this.Pesquisa_TextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox_Clientes_Deletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseridos_Data);
            this.MaximizeBox = false;
            this.Name = "Deletar_Clientes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deletar_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Deletar_Clientes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Procurar_Button;
        private System.Windows.Forms.ComboBox Categorias_Procurar_Clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Digite_Label;
        private System.Windows.Forms.TextBox Pesquisa_TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBox_Clientes_Deletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Inseridos_Data;
    }
}