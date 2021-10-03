
namespace Library
{
    partial class Inserir_Venda_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Voltar_Button = new System.Windows.Forms.Button();
            this.Enviar_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Inseridos_Data = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TexBox_Valor_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Id_Cliente_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Categoria_Pagamento = new System.Windows.Forms.ComboBox();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade_Coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preço_total_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livro_id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Voltar_Button
            // 
            this.Voltar_Button.Location = new System.Drawing.Point(627, 527);
            this.Voltar_Button.Name = "Voltar_Button";
            this.Voltar_Button.Size = new System.Drawing.Size(75, 40);
            this.Voltar_Button.TabIndex = 26;
            this.Voltar_Button.Text = "Voltar";
            this.Voltar_Button.UseVisualStyleBackColor = true;
            this.Voltar_Button.Click += new System.EventHandler(this.Voltar_Button_Click);
            // 
            // Enviar_Button
            // 
            this.Enviar_Button.Location = new System.Drawing.Point(724, 527);
            this.Enviar_Button.Name = "Enviar_Button";
            this.Enviar_Button.Size = new System.Drawing.Size(109, 40);
            this.Enviar_Button.TabIndex = 25;
            this.Enviar_Button.Text = "Finalizar Venda";
            this.Enviar_Button.UseVisualStyleBackColor = true;
            this.Enviar_Button.Click += new System.EventHandler(this.Enviar_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.TabIndex = 33;
            this.label1.Text = "CAIXA";
            // 
            // Inseridos_Data
            // 
            this.Inseridos_Data.AllowUserToResizeColumns = false;
            this.Inseridos_Data.AllowUserToResizeRows = false;
            this.Inseridos_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Inseridos_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Inseridos_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inseridos_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_Livro,
            this.Nome_Autor,
            this.Coluna_Preço,
            this.Quantidade_Coluna,
            this.preço_total_column,
            this.livro_id_column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Inseridos_Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Inseridos_Data.Location = new System.Drawing.Point(12, 104);
            this.Inseridos_Data.Name = "Inseridos_Data";
            this.Inseridos_Data.Size = new System.Drawing.Size(596, 351);
            this.Inseridos_Data.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Inserir Produtos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 119);
            this.button1.TabIndex = 45;
            this.button1.Text = "Adicionar Produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Adicionar_Livro_Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(627, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 110);
            this.button3.TabIndex = 47;
            this.button3.Text = "Escolher Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Escolher_Cliente_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(627, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 110);
            this.button4.TabIndex = 48;
            this.button4.Text = "Excluir Produto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Excluir_Livro_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Valor Total";
            // 
            // TexBox_Valor_Total
            // 
            this.TexBox_Valor_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBox_Valor_Total.Location = new System.Drawing.Point(120, 493);
            this.TexBox_Valor_Total.Name = "TexBox_Valor_Total";
            this.TexBox_Valor_Total.ReadOnly = true;
            this.TexBox_Valor_Total.Size = new System.Drawing.Size(145, 27);
            this.TexBox_Valor_Total.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "ID Cliente";
            // 
            // Id_Cliente_TextBox
            // 
            this.Id_Cliente_TextBox.Location = new System.Drawing.Point(76, 554);
            this.Id_Cliente_TextBox.Name = "Id_Cliente_TextBox";
            this.Id_Cliente_TextBox.ReadOnly = true;
            this.Id_Cliente_TextBox.Size = new System.Drawing.Size(38, 20);
            this.Id_Cliente_TextBox.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Forma de Pagamento";
            // 
            // Categoria_Pagamento
            // 
            this.Categoria_Pagamento.DisplayMember = "vs";
            this.Categoria_Pagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categoria_Pagamento.FormattingEnabled = true;
            this.Categoria_Pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão de Crédito"});
            this.Categoria_Pagamento.Location = new System.Drawing.Point(483, 495);
            this.Categoria_Pagamento.Name = "Categoria_Pagamento";
            this.Categoria_Pagamento.Size = new System.Drawing.Size(125, 21);
            this.Categoria_Pagamento.TabIndex = 55;
            this.Categoria_Pagamento.SelectedValueChanged += new System.EventHandler(this.Categoria_Pagamento_SelectedValueChanged);
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.HeaderText = "Nome do Livro";
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            // 
            // Nome_Autor
            // 
            this.Nome_Autor.HeaderText = "Nome do Autor";
            this.Nome_Autor.Name = "Nome_Autor";
            this.Nome_Autor.ReadOnly = true;
            // 
            // Coluna_Preço
            // 
            this.Coluna_Preço.HeaderText = "Preço Unitário";
            this.Coluna_Preço.Name = "Coluna_Preço";
            this.Coluna_Preço.ReadOnly = true;
            // 
            // Quantidade_Coluna
            // 
            this.Quantidade_Coluna.HeaderText = "Quantidade";
            this.Quantidade_Coluna.Name = "Quantidade_Coluna";
            this.Quantidade_Coluna.ReadOnly = true;
            // 
            // preço_total_column
            // 
            this.preço_total_column.HeaderText = "Preço Total";
            this.preço_total_column.Name = "preço_total_column";
            // 
            // livro_id_column
            // 
            this.livro_id_column.FillWeight = 75F;
            this.livro_id_column.HeaderText = "ID";
            this.livro_id_column.Name = "livro_id_column";
            // 
            // Inserir_Venda_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 579);
            this.Controls.Add(this.Categoria_Pagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Id_Cliente_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TexBox_Valor_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Inseridos_Data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Voltar_Button);
            this.Controls.Add(this.Enviar_Button);
            this.MaximizeBox = false;
            this.Name = "Inserir_Venda_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Venda";
            this.Activated += new System.EventHandler(this.Inserir_Venda_Form_Enter);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inserir_Venda_FormClosing);
            this.Load += new System.EventHandler(this.Inserir_Livro_Form_Load);
            this.MouseHover += new System.EventHandler(this.Inserir_Venda_Form_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.Inseridos_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Voltar_Button;
        private System.Windows.Forms.Button Enviar_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Inseridos_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TexBox_Valor_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Id_Cliente_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Categoria_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade_Coluna;
        private System.Windows.Forms.DataGridViewTextBoxColumn preço_total_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn livro_id_column;
    }
}