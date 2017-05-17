namespace FrmLogin
{
    partial class MdiPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlterarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcluirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAlterarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExcluirUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTelaInicial = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduto,
            this.tsmiUsuario,
            this.tsmiTelaInicial});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(584, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // tsmiProduto
            // 
            this.tsmiProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlterarProduto,
            this.tsmiCadastrarProduto,
            this.tsmiConsultarProduto,
            this.tsmiExcluirProduto});
            this.tsmiProduto.Name = "tsmiProduto";
            this.tsmiProduto.Size = new System.Drawing.Size(62, 20);
            this.tsmiProduto.Text = "Produto";
            // 
            // tsmiAlterarProduto
            // 
            this.tsmiAlterarProduto.Name = "tsmiAlterarProduto";
            this.tsmiAlterarProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiAlterarProduto.Text = "Alterar";
            this.tsmiAlterarProduto.Click += new System.EventHandler(this.tsmiAlterarProduto_Click);
            // 
            // tsmiCadastrarProduto
            // 
            this.tsmiCadastrarProduto.Name = "tsmiCadastrarProduto";
            this.tsmiCadastrarProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiCadastrarProduto.Text = "Cadastrar";
            this.tsmiCadastrarProduto.Click += new System.EventHandler(this.tsmiCadastrarProduto_Click);
            // 
            // tsmiConsultarProduto
            // 
            this.tsmiConsultarProduto.Name = "tsmiConsultarProduto";
            this.tsmiConsultarProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiConsultarProduto.Text = "Consultar";
            this.tsmiConsultarProduto.Click += new System.EventHandler(this.tsmiConsultarProduto_Click);
            // 
            // tsmiExcluirProduto
            // 
            this.tsmiExcluirProduto.Name = "tsmiExcluirProduto";
            this.tsmiExcluirProduto.Size = new System.Drawing.Size(152, 22);
            this.tsmiExcluirProduto.Text = "Excluir";
            this.tsmiExcluirProduto.Click += new System.EventHandler(this.tsmiExcluirProduto_Click);
            // 
            // tsmiUsuario
            // 
            this.tsmiUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAlterarUsuario,
            this.tsmiCadastrarUsuario,
            this.tsmiConsultarUsuario,
            this.tsmiExcluirUsuario});
            this.tsmiUsuario.Name = "tsmiUsuario";
            this.tsmiUsuario.Size = new System.Drawing.Size(59, 20);
            this.tsmiUsuario.Text = "Usuário";
            // 
            // tsmiAlterarUsuario
            // 
            this.tsmiAlterarUsuario.Name = "tsmiAlterarUsuario";
            this.tsmiAlterarUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiAlterarUsuario.Text = "Alterar";
            this.tsmiAlterarUsuario.Click += new System.EventHandler(this.tsmiAlterarUsuario_Click);
            // 
            // tsmiCadastrarUsuario
            // 
            this.tsmiCadastrarUsuario.Name = "tsmiCadastrarUsuario";
            this.tsmiCadastrarUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiCadastrarUsuario.Text = "Cadastrar";
            this.tsmiCadastrarUsuario.Click += new System.EventHandler(this.tsmiCadastrarUsuario_Click);
            // 
            // tsmiConsultarUsuario
            // 
            this.tsmiConsultarUsuario.Name = "tsmiConsultarUsuario";
            this.tsmiConsultarUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiConsultarUsuario.Text = "Consultar";
            this.tsmiConsultarUsuario.Click += new System.EventHandler(this.tsmiConsultarUsuario_Click);
            // 
            // tsmiExcluirUsuario
            // 
            this.tsmiExcluirUsuario.Name = "tsmiExcluirUsuario";
            this.tsmiExcluirUsuario.Size = new System.Drawing.Size(152, 22);
            this.tsmiExcluirUsuario.Text = "Excluir";
            this.tsmiExcluirUsuario.Click += new System.EventHandler(this.tsmiExcluirUsuario_Click);
            // 
            // tsmiTelaInicial
            // 
            this.tsmiTelaInicial.Name = "tsmiTelaInicial";
            this.tsmiTelaInicial.Size = new System.Drawing.Size(74, 20);
            this.tsmiTelaInicial.Text = "Tela Inicial";
            this.tsmiTelaInicial.Click += new System.EventHandler(this.tsmiTelaInicial_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MdiPrincipal";
            this.Text = "Hippo Mercado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MdiPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlterarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcluirProduto;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiAlterarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiExcluirUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiTelaInicial;
    }
}



