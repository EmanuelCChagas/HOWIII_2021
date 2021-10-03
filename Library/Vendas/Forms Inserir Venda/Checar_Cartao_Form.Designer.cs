
namespace Library
{
    partial class Checar_Cartao_Form
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
            this.Validar_button = new System.Windows.Forms.Button();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cartao_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cvv_TextBox = new System.Windows.Forms.TextBox();
            this.Validade_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Validar_button
            // 
            this.Validar_button.Location = new System.Drawing.Point(476, 230);
            this.Validar_button.Name = "Validar_button";
            this.Validar_button.Size = new System.Drawing.Size(89, 39);
            this.Validar_button.TabIndex = 71;
            this.Validar_button.Text = "Validar";
            this.Validar_button.UseVisualStyleBackColor = true;
            this.Validar_button.UseWaitCursor = true;
            this.Validar_button.Click += new System.EventHandler(this.Validar_button_Click);
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(369, 230);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(88, 39);
            this.Voltar_Button.TabIndex = 69;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.UseWaitCursor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Bandeira de Cartão de Crédito";
            this.label3.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(294, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(98, 27);
            this.textBox1.TabIndex = 82;
            this.textBox1.Text = "MasterCard";
            this.textBox1.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Número do Cartão";
            this.label5.UseWaitCursor = true;
            // 
            // Cartao_TextBox
            // 
            this.Cartao_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartao_TextBox.Location = new System.Drawing.Point(190, 64);
            this.Cartao_TextBox.MaxLength = 20;
            this.Cartao_TextBox.Name = "Cartao_TextBox";
            this.Cartao_TextBox.Size = new System.Drawing.Size(375, 27);
            this.Cartao_TextBox.TabIndex = 85;
            this.Cartao_TextBox.UseWaitCursor = true;
            this.Cartao_TextBox.Leave += new System.EventHandler(this.Cartao_TextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 86;
            this.label4.Text = "Data de Validade";
            this.label4.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 25);
            this.label6.TabIndex = 87;
            this.label6.Text = "Código Segurança (CVV)";
            this.label6.UseWaitCursor = true;
            // 
            // Cvv_TextBox
            // 
            this.Cvv_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cvv_TextBox.Location = new System.Drawing.Point(270, 163);
            this.Cvv_TextBox.MaxLength = 3;
            this.Cvv_TextBox.Name = "Cvv_TextBox";
            this.Cvv_TextBox.Size = new System.Drawing.Size(122, 27);
            this.Cvv_TextBox.TabIndex = 89;
            this.Cvv_TextBox.UseWaitCursor = true;
            this.Cvv_TextBox.Leave += new System.EventHandler(this.Cvv_TextBox_Leave);
            // 
            // Validade_DatePicker
            // 
            this.Validade_DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validade_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Validade_DatePicker.Location = new System.Drawing.Point(190, 117);
            this.Validade_DatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.Validade_DatePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.Validade_DatePicker.Name = "Validade_DatePicker";
            this.Validade_DatePicker.Size = new System.Drawing.Size(109, 27);
            this.Validade_DatePicker.TabIndex = 90;
            this.Validade_DatePicker.UseWaitCursor = true;
            // 
            // Checar_Cartao_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 278);
            this.Controls.Add(this.Validade_DatePicker);
            this.Controls.Add(this.Cvv_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cartao_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Validar_button);
            this.Controls.Add(this.Voltar_Button);
            this.MaximizeBox = false;
            this.Name = "Checar_Cartao_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checar Cartao";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Validar_button;
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cartao_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cvv_TextBox;
        private System.Windows.Forms.DateTimePicker Validade_DatePicker;
    }
}