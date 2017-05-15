namespace FrmLogin
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.Maroon;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProduto.Image = global::FrmLogin.Properties.Resources.Produto;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.Location = new System.Drawing.Point(72, 130);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(155, 148);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Maroon;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Image = global::FrmLogin.Properties.Resources.Usuario;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(617, 130);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(155, 148);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::FrmLogin.Properties.Resources.Pedido1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(346, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 148);
            this.button1.TabIndex = 5;
            this.button1.Text = "Categoria";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnProduto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicial";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button button1;
    }
}