using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmInicial : Form
    {
        private ChamarTela chamarTela;

        public FrmInicial()
        {
            chamarTela = new ChamarTela();
            InitializeComponent();

        }
        
        private void btnProduto_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioConsultarExcluir();
            
        }
        
        private void FrmInicial_Load(object sender, EventArgs e)
        {
            if (Dados.tipoPerfil.Equals("E"))
            {
                btnCategoria.Enabled = false;
                btnProduto.Enabled = false;
                btnUsuario.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chamarTela.CategoriaCrud();
            FrmCategoriaCrud frmCategoria = new FrmCategoriaCrud(false);
            frmCategoria.MdiParent = MdiPrincipal.ActiveForm;
            frmCategoria.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.MdiParent = MdiPrincipal.ActiveForm;
            estoque.Show();
            this.Close();
        }
    }
}
