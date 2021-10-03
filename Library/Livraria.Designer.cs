
namespace Library
{
    partial class Livraria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Inserir_Livros = new System.Windows.Forms.ToolStripMenuItem();
            this.Verificar_Livros = new System.Windows.Forms.ToolStripMenuItem();
            this.Atualizar_Livros = new System.Windows.Forms.ToolStripMenuItem();
            this.Deletar_Livros = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Inserir_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Verificar_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Atualizar_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Deletar_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarCorrigirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseDeDadosToolStripMenuItem
            // 
            this.baseDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.baseDeDadosToolStripMenuItem.Name = "baseDeDadosToolStripMenuItem";
            this.baseDeDadosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.baseDeDadosToolStripMenuItem.Text = "Livraria";
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inserir_Livros,
            this.Verificar_Livros,
            this.Atualizar_Livros,
            this.Deletar_Livros});
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inserirToolStripMenuItem.Text = "Livros";
            // 
            // Inserir_Livros
            // 
            this.Inserir_Livros.Name = "Inserir_Livros";
            this.Inserir_Livros.Size = new System.Drawing.Size(120, 22);
            this.Inserir_Livros.Text = "Inserir";
            this.Inserir_Livros.Click += new System.EventHandler(this.Inserir_Livros_Click);
            // 
            // Verificar_Livros
            // 
            this.Verificar_Livros.Name = "Verificar_Livros";
            this.Verificar_Livros.Size = new System.Drawing.Size(120, 22);
            this.Verificar_Livros.Text = "Verificar";
            this.Verificar_Livros.Click += new System.EventHandler(this.Verificar_Livros_Click);
            // 
            // Atualizar_Livros
            // 
            this.Atualizar_Livros.Name = "Atualizar_Livros";
            this.Atualizar_Livros.Size = new System.Drawing.Size(120, 22);
            this.Atualizar_Livros.Text = "Atualizar";
            this.Atualizar_Livros.Click += new System.EventHandler(this.Atualizar_Livros_Click);
            // 
            // Deletar_Livros
            // 
            this.Deletar_Livros.Name = "Deletar_Livros";
            this.Deletar_Livros.Size = new System.Drawing.Size(120, 22);
            this.Deletar_Livros.Text = "Deletar";
            this.Deletar_Livros.Click += new System.EventHandler(this.Deletar_Livros_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inserir_Clientes,
            this.Verificar_Clientes,
            this.Atualizar_Clientes,
            this.Deletar_Clientes});
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarToolStripMenuItem.Text = "Clientes";
            // 
            // Inserir_Clientes
            // 
            this.Inserir_Clientes.Name = "Inserir_Clientes";
            this.Inserir_Clientes.Size = new System.Drawing.Size(120, 22);
            this.Inserir_Clientes.Text = "Inserir";
            this.Inserir_Clientes.Click += new System.EventHandler(this.Inserir_Clientes_Click);
            // 
            // Verificar_Clientes
            // 
            this.Verificar_Clientes.Name = "Verificar_Clientes";
            this.Verificar_Clientes.Size = new System.Drawing.Size(120, 22);
            this.Verificar_Clientes.Text = "Verificar";
            this.Verificar_Clientes.Click += new System.EventHandler(this.Verificar_Clientes_Click);
            // 
            // Atualizar_Clientes
            // 
            this.Atualizar_Clientes.Name = "Atualizar_Clientes";
            this.Atualizar_Clientes.Size = new System.Drawing.Size(120, 22);
            this.Atualizar_Clientes.Text = "Atualizar";
            this.Atualizar_Clientes.Click += new System.EventHandler(this.Atualizar_Clientes_Click);
            // 
            // Deletar_Clientes
            // 
            this.Deletar_Clientes.Name = "Deletar_Clientes";
            this.Deletar_Clientes.Size = new System.Drawing.Size(120, 22);
            this.Deletar_Clientes.Text = "Deletar";
            this.Deletar_Clientes.Click += new System.EventHandler(this.Deletar_Clientes_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirToolStripMenuItem2,
            this.verificarToolStripMenuItem1,
            this.atualizarCorrigirToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // inserirToolStripMenuItem2
            // 
            this.inserirToolStripMenuItem2.Name = "inserirToolStripMenuItem2";
            this.inserirToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.inserirToolStripMenuItem2.Text = "Nova Venda";
            this.inserirToolStripMenuItem2.Click += new System.EventHandler(this.Inserir_Vendas_Click);
            // 
            // verificarToolStripMenuItem1
            // 
            this.verificarToolStripMenuItem1.Name = "verificarToolStripMenuItem1";
            this.verificarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.verificarToolStripMenuItem1.Text = "Verificar Vendas";
            this.verificarToolStripMenuItem1.Click += new System.EventHandler(this.Verificar_Vendas_Click);
            // 
            // atualizarCorrigirToolStripMenuItem
            // 
            this.atualizarCorrigirToolStripMenuItem.Name = "atualizarCorrigirToolStripMenuItem";
            this.atualizarCorrigirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atualizarCorrigirToolStripMenuItem.Text = "Relatório";
            this.atualizarCorrigirToolStripMenuItem.Click += new System.EventHandler(this.Relatorio_Vendas_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 60);
            this.label1.MinimumSize = new System.Drawing.Size(150, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo(a)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Livraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(861, 549);
            this.Name = "Livraria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Livraria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Inserir_Livros;
        private System.Windows.Forms.ToolStripMenuItem Verificar_Livros;
        private System.Windows.Forms.ToolStripMenuItem Atualizar_Livros;
        private System.Windows.Forms.ToolStripMenuItem Deletar_Livros;
        private System.Windows.Forms.ToolStripMenuItem Inserir_Clientes;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Verificar_Clientes;
        private System.Windows.Forms.ToolStripMenuItem Atualizar_Clientes;
        private System.Windows.Forms.ToolStripMenuItem Deletar_Clientes;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarCorrigirToolStripMenuItem;
    }
}

