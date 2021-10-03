
namespace Library
{
    partial class Inserir_Clientes_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.Enviar_Button = new System.Windows.Forms.Button();
            this.Nome_Cliente_Box = new System.Windows.Forms.TextBox();
            this.ome_Cliente = new System.Windows.Forms.Label();
            this.Email_Clientes = new System.Windows.Forms.Label();
            this.Email_Clientes_TextBox = new System.Windows.Forms.TextBox();
            this.Telefone_CLientes = new System.Windows.Forms.Label();
            this.Telefone_Clientes_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AllowUserToResizeColumns = false;
            this.Inseridos_Data.AllowUserToResizeRows = false;
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Inseridos_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Inseridos_Data.DefaultCellStyle = dataGridViewCellStyle8;
            this.Inseridos_Data.Location = new System.Drawing.Point(12, 133);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(821, 326);
            this.Inseridos_Data.TabIndex = 27;
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(663, 475);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 23);
            this.Voltar_Button.TabIndex = 26;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Enviar_Button
            // 
            this.Enviar_Button.Location = new System.Drawing.Point(758, 475);
            this.Enviar_Button.Name = "Enviar_Button";
            this.Enviar_Button.Size = new System.Drawing.Size(75, 23);
            this.Enviar_Button.TabIndex = 25;
            this.Enviar_Button.Text = "Enviar";
            this.Enviar_Button.UseVisualStyleBackColor = true;
            this.Enviar_Button.Click += new System.EventHandler(this.Enviar_Button_Click);
            // 
            // Nome_Cliente_Box
            // 
            this.Nome_Cliente_Box.Location = new System.Drawing.Point(53, 39);
            this.Nome_Cliente_Box.Name = "Nome_Cliente_Box";
            this.Nome_Cliente_Box.Size = new System.Drawing.Size(300, 20);
            this.Nome_Cliente_Box.TabIndex = 16;
            // 
            // ome_Cliente
            // 
            this.ome_Cliente.AutoSize = true;
            this.ome_Cliente.Location = new System.Drawing.Point(12, 43);
            this.ome_Cliente.Name = "ome_Cliente";
            this.ome_Cliente.Size = new System.Drawing.Size(35, 13);
            this.ome_Cliente.TabIndex = 15;
            this.ome_Cliente.Text = "Nome";
            // 
            // Email_Clientes
            // 
            this.Email_Clientes.AutoSize = true;
            this.Email_Clientes.Location = new System.Drawing.Point(384, 42);
            this.Email_Clientes.Name = "Email_Clientes";
            this.Email_Clientes.Size = new System.Drawing.Size(32, 13);
            this.Email_Clientes.TabIndex = 28;
            this.Email_Clientes.Text = "Email";
            // 
            // Email_Clientes_TextBox
            // 
            this.Email_Clientes_TextBox.Location = new System.Drawing.Point(433, 38);
            this.Email_Clientes_TextBox.Name = "Email_Clientes_TextBox";
            this.Email_Clientes_TextBox.Size = new System.Drawing.Size(233, 20);
            this.Email_Clientes_TextBox.TabIndex = 29;
            this.Email_Clientes_TextBox.Leave += new System.EventHandler(this.Email_Clientes_TextBox_Leave);
            // 
            // Telefone_CLientes
            // 
            this.Telefone_CLientes.AutoSize = true;
            this.Telefone_CLientes.Location = new System.Drawing.Point(12, 80);
            this.Telefone_CLientes.Name = "Telefone_CLientes";
            this.Telefone_CLientes.Size = new System.Drawing.Size(49, 13);
            this.Telefone_CLientes.TabIndex = 30;
            this.Telefone_CLientes.Text = "Telefone";
            // 
            // Telefone_Clientes_MaskedTextBox
            // 
            this.Telefone_Clientes_MaskedTextBox.Location = new System.Drawing.Point(67, 77);
            this.Telefone_Clientes_MaskedTextBox.Mask = "00-00000-0000";
            this.Telefone_Clientes_MaskedTextBox.Name = "Telefone_Clientes_MaskedTextBox";
            this.Telefone_Clientes_MaskedTextBox.Size = new System.Drawing.Size(95, 20);
            this.Telefone_Clientes_MaskedTextBox.TabIndex = 31;
            this.Telefone_Clientes_MaskedTextBox.Leave += new System.EventHandler(this.Telefone_Clientes_MaskedTextBox_Leave);
            // 
            // Inserir_Clientes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.Telefone_Clientes_MaskedTextBox);
            this.Controls.Add(this.Telefone_CLientes);
            this.Controls.Add(this.Email_Clientes_TextBox);
            this.Controls.Add(this.Email_Clientes);
            this.Controls.Add(this.Inseridos_Data);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Enviar_Button);
            this.Controls.Add(this.Nome_Cliente_Box);
            this.Controls.Add(this.ome_Cliente);
            this.MaximizeBox = false;
            this.Name = "Inserir_Clientes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inserir_Clientes_FormClosing);
            this.Load += new System.EventHandler(this.Inserir_Clientes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Button Enviar_Button;
        private System.Windows.Forms.TextBox Nome_Cliente_Box;
        private System.Windows.Forms.Label ome_Cliente;
        private System.Windows.Forms.Label Email_Clientes;
        private System.Windows.Forms.TextBox Email_Clientes_TextBox;
        private System.Windows.Forms.Label Telefone_CLientes;
        private System.Windows.Forms.MaskedTextBox Telefone_Clientes_MaskedTextBox;
    }
}