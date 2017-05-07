using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace FrmLogin
{
    public partial class FrmProdutoAlterarCadastrar : Form
    {
        private ChamarTela chamarTela;

        public FrmProdutoAlterarCadastrar()
        {
            chamarTela = new ChamarTela();
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoAlterarCadastrar();
            Close();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            string produtoAtivo = produtoAtivoSim.Checked ? "1" : "0";

            inserir.InserirProduto(txtNome.Text,txtDescricao.Text,
                Convert.ToDecimal(txtPreco.Text), Convert.ToDecimal(txtDesconto.Text),1,produtoAtivo,
                Convert.ToInt32(txtIdUsuario.Text),Convert.ToInt32(txtQuantidade.Text));        
            chamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        
        
        private void menuProdutoAlterar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void menuProdutoCadastrar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        private void menuProdutoConsultar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
            Close();
        }


        private void FrmProdutoAlterarCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            FrmCategoriaCrud frmCategoria = new FrmCategoriaCrud();
            frmCategoria.ShowDialog();
        }
    }
}
