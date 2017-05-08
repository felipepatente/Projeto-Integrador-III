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
using ObjetoTransferencia;

namespace FrmLogin
{
    public partial class FrmProdutoConsultarExcluir : Form
    {
        private ChamarTela chamarTela;

        public FrmProdutoConsultarExcluir()
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
            Deletar deletar = new Deletar();
            Produto produtoSelecionado = (dgvProduto.SelectedRows[0].DataBoundItem as Produto);
            deletar.DeletarProduto(produtoSelecionado.IdProduto);

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
            Consultar consultar = new Consultar();
            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = null;

            string opcao;

            if (rdbNome.Checked)
            {
                opcao = "nomeProduto";
            }else if (rdbCategoria.Checked)
            {
                opcao = "nomeCategoria";
            }else
            {
                opcao = "precProduto";
            }

            if (txtPesquisar.Text == "")
            {
                txtPesquisar.Text = " ";
            }

            dgvProduto.DataSource = consultar.ConsultarProduto(opcao, txtPesquisar.Text);
            dgvProduto.Refresh();
            dgvProduto.Update();            
            //chamarTela.ProdutoConsultarExcluir();
            //Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoAlterarCadastrar();
            Close();
        }
       
    }
}
