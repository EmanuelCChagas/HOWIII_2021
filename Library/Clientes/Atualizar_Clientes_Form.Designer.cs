
namespace Library
{
    partial class Atualizar_Clientes_Form
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
            this.TextBox_Cliente_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Categorias_Atualizar_Clientes = new System.Windows.Forms.ComboBox();
            this.Att_Label = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.Atualizar_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox_Cliente_ID
            // 
            this.TextBox_Cliente_ID.Location = new System.Drawing.Point(707, 22);
            this.TextBox_Cliente_ID.Name = "TextBox_Cliente_ID";
            this.TextBox_Cliente_ID.Size = new System.Drawing.Size(63, 20);
            this.TextBox_Cliente_ID.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Selecione a ID do Cliente Para Atualizar";
            // 
            // Categorias_Atualizar_Clientes
            // 
            this.Categorias_Atualizar_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorias_Atualizar_Clientes.FormattingEnabled = true;
            this.Categorias_Atualizar_Clientes.Items.AddRange(new object[] {
            "Nome",
            "Telefone",
            "Email"});
            this.Categorias_Atualizar_Clientes.Location = new System.Drawing.Point(200, 21);
            this.Categorias_Atualizar_Clientes.Name = "Categorias_Atualizar_Clientes";
            this.Categorias_Atualizar_Clientes.Size = new System.Drawing.Size(121, 21);
            this.Categorias_Atualizar_Clientes.TabIndex = 37;
            // 
            // Att_Label
            // 
            this.Att_Label.Location = new System.Drawing.Point(200, 58);
            this.Att_Label.Name = "Att_Label";
            this.Att_Label.Size = new System.Drawing.Size(121, 20);
            this.Att_Label.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Escreva A Atualização";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Escolha o Campo para Atualizar";
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AllowUserToResizeColumns = false;
            this.Inseridos_Data.AllowUserToResizeRows = false;
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Location = new System.Drawing.Point(21, 99);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(786, 324);
            this.Inseridos_Data.TabIndex = 33;
            this.Inseridos_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Inseridos_Data_CellClick);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(663, 475);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 41;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Atualizar_Button
            // 
            this.Atualizar_Button.Location = new System.Drawing.Point(758, 475);
            this.Atualizar_Button.Name = "Atualizar_Button";
            this.Atualizar_Button.Size = new System.Drawing.Size(75, 23);
            this.Atualizar_Button.TabIndex = 40;
            this.Atualizar_Button.Text = "Atualizar";
            this.Atualizar_Button.UseVisualStyleBackColor = true;
            this.Atualizar_Button.Click += new System.EventHandler(this.Atualizar_Button_Click);
            // 
            // Atualizar_Clientes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Atualizar_Button);
            this.Controls.Add(this.TextBox_Cliente_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Categorias_Atualizar_Clientes);
            this.Controls.Add(this.Att_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Inseridos_Data);
            this.MaximizeBox = false;
            this.Name = "Atualizar_Clientes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atualizar_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Atualizar_Clientes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Cliente_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Categorias_Atualizar_Clientes;
        private System.Windows.Forms.TextBox Att_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Button Atualizar_Button;
    }
}