
namespace AulasRADMDIBD
{
    partial class FrmPrincipal
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
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePessoasFísicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePessoasJurídicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCategoriasProdutosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePessoasFísicasToolStripMenuItem,
            this.cadastroDePessoasJurídicasToolStripMenuItem,
            this.cadastroCategoriasProdutosMenuItem,
            this.cadastroProdutosMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDePessoasFísicasToolStripMenuItem
            // 
            this.cadastroDePessoasFísicasToolStripMenuItem.Name = "cadastroDePessoasFísicasToolStripMenuItem";
            this.cadastroDePessoasFísicasToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.cadastroDePessoasFísicasToolStripMenuItem.Text = "Cadastro de Pessoas &Físicas";
            this.cadastroDePessoasFísicasToolStripMenuItem.Click += new System.EventHandler(this.cadsatroDePessoasFísicasToolStripMenuItem_Click);
            // 
            // cadastroDePessoasJurídicasToolStripMenuItem
            // 
            this.cadastroDePessoasJurídicasToolStripMenuItem.Name = "cadastroDePessoasJurídicasToolStripMenuItem";
            this.cadastroDePessoasJurídicasToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.cadastroDePessoasJurídicasToolStripMenuItem.Text = "Cadastro de Pessoas &Jurídicas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(398, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroProdutosMenuItem
            // 
            this.cadastroProdutosMenuItem.Name = "cadastroProdutosMenuItem";
            this.cadastroProdutosMenuItem.Size = new System.Drawing.Size(401, 30);
            this.cadastroProdutosMenuItem.Text = "Cadastro de &Produtos";
            // 
            // cadastroCategoriasProdutosMenuItem
            // 
            this.cadastroCategoriasProdutosMenuItem.Name = "cadastroCategoriasProdutosMenuItem";
            this.cadastroCategoriasProdutosMenuItem.Size = new System.Drawing.Size(401, 30);
            this.cadastroCategoriasProdutosMenuItem.Text = "Cadastro de &Categorias de Produtos";
            this.cadastroCategoriasProdutosMenuItem.Click += new System.EventHandler(this.cadastroCategoriasProdutosMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.vendaToolStripMenuItem.Text = "&Venda";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Aplicativo MDI com manipulação de tabelas de BD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePessoasFísicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePessoasJurídicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCategoriasProdutosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}

