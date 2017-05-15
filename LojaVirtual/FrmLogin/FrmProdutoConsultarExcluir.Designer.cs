namespace FrmLogin
{
    partial class FrmProdutoConsultarExcluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoConsultarExcluir));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.rdbPreco = new System.Windows.Forms.RadioButton();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescProm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar Por : ";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.BackColor = System.Drawing.Color.Transparent;
            this.rdbNome.Checked = true;
            this.rdbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNome.ForeColor = System.Drawing.Color.White;
            this.rdbNome.Location = new System.Drawing.Point(208, 154);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(67, 20);
            this.rdbNome.TabIndex = 11;
            this.rdbNome.TabStop = true;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = false;
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.rdbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCategoria.ForeColor = System.Drawing.Color.White;
            this.rdbCategoria.Location = new System.Drawing.Point(316, 155);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(94, 20);
            this.rdbCategoria.TabIndex = 12;
            this.rdbCategoria.TabStop = true;
            this.rdbCategoria.Text = "Categoria";
            this.rdbCategoria.UseVisualStyleBackColor = false;
            // 
            // rdbPreco
            // 
            this.rdbPreco.AutoSize = true;
            this.rdbPreco.BackColor = System.Drawing.Color.Transparent;
            this.rdbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPreco.ForeColor = System.Drawing.Color.White;
            this.rdbPreco.Location = new System.Drawing.Point(448, 155);
            this.rdbPreco.Name = "rdbPreco";
            this.rdbPreco.Size = new System.Drawing.Size(67, 20);
            this.rdbPreco.TabIndex = 13;
            this.rdbPreco.TabStop = true;
            this.rdbPreco.Text = "Preço";
            this.rdbPreco.UseVisualStyleBackColor = false;
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Nome,
            this.Descrição,
            this.Preço,
            this.DescProm,
            this.Categoria,
            this.idCategoria,
            this.Ativo,
            this.Quantidade});
            this.dgvProduto.Location = new System.Drawing.Point(12, 234);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(843, 269);
            this.dgvProduto.TabIndex = 14;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "idProduto";
            this.IdProduto.HeaderText = "IdProduto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Width = 70;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nomeProduto";
            this.Nome.HeaderText = "Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descProduto";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 300;
            // 
            // Preço
            // 
            this.Preço.DataPropertyName = "precProduto";
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 50;
            // 
            // DescProm
            // 
            this.DescProm.DataPropertyName = "descontoPromocao";
            this.DescProm.HeaderText = "Desconto";
            this.DescProm.Name = "DescProm";
            this.DescProm.ReadOnly = true;
            this.DescProm.Width = 80;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "nomeCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Width = 70;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "ativoProduto";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Width = 50;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "qtdMinEstoque";
            this.Quantidade.HeaderText = "Qtd Minima";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 50;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisar.Location = new System.Drawing.Point(133, 196);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(531, 20);
            this.txtPesquisar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pesquisar";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = global::FrmLogin.Properties.Resources.Fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(675, 36);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(110, 95);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Image = global::FrmLogin.Properties.Resources.Excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(515, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 95);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Image = global::FrmLogin.Properties.Resources.Alterar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(360, 36);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 95);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::FrmLogin.Properties.Resources.Consultar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(208, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 95);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = global::FrmLogin.Properties.Resources.Adicionar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(52, 36);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 95);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmProdutoConsultarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.rdbPreco);
            this.Controls.Add(this.rdbCategoria);
            this.Controls.Add(this.rdbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdutoConsultarExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProdutoConsultarExcluir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.RadioButton rdbCategoria;
        private System.Windows.Forms.RadioButton rdbPreco;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescProm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}