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
    public partial class FrmProdutoAlterarCadastrar : Form
    {
        private ChamarTela chamarTela;
        
        public void Construtor()
        {
            chamarTela = new ChamarTela();
            InitializeComponent();
        }

        public FrmProdutoAlterarCadastrar()
        {
            this.Construtor();
        }

        public FrmProdutoAlterarCadastrar(Produto produto)
        {
            this.Construtor();
            this.SetarProduto(produto);
        }

        // -------------------------------------------
        public FrmProdutoAlterarCadastrar(int id)
        {
            this.Construtor();
            txtIdUsuario.Text = Convert.ToString(id);
        }

        public void Set(string id)
        {
            txtIdUsuario.Text = id; 
        }

        public string Get()
        {
            return txtIdUsuario.Text;
        }
        // -------------------------------------------

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
            AtualizarProduto();
            chamarTela.ProdutoAlterarCadastrar();
            Close();
        }

        public void SetarProduto(Produto produto)
        {

            /*string nomeProduto, string descProduto, decimal precProduto, decimal descontoPromocao,
            int idCategoria, string ativoProduto, int idUsuario, int qtdMinEstoque, int idProduto);*/

            txtNome.Text = produto.NomeProduto;
            txtDescricao.Text = produto.DescProduto;
            txtPreco.Text = Convert.ToString(produto.PrecProduto);
            txtDesconto.Text = Convert.ToString(produto.DescontoPromocao);
            txtIdCategoria.Text = Convert.ToString(produto.IdCategoria);
            txtQuantidade.Text = Convert.ToString(produto.QtdMinEstoque);
            
            if (produto.AtivoProduto.Equals("1"))
            {
                produtoAtivoSim.Checked = true;
            }
            else
            {
                produtoAtivoNao.Checked = true;
            }
            
            txtIdUsuario.Text = Convert.ToString(produto.IdUsuario);
            txtQuantidade.Text = Convert.ToString(produto.QtdMinEstoque);
            txtIdProduto.Text = Convert.ToString(produto.IdProduto);
        }

        private void AtualizarProduto()
        {
            Atualizar atualizar = new Atualizar();
            
            string ativo = "0";
            if (produtoAtivoSim.Checked)
            {
                ativo = "1";
            }
            
            atualizar.AtualizarProduto(txtNome.Text, txtDescricao.Text, Convert.ToDecimal(txtPreco.Text), 
                Convert.ToDecimal(txtDesconto.Text), Convert.ToInt32(txtIdCategoria.Text), ativo, 
                Convert.ToInt32(txtIdUsuario.Text), Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtIdProduto.Text));
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
                Convert.ToDecimal(txtPreco.Text), Convert.ToDecimal(txtDesconto.Text),Convert.ToInt32(txtIdCategoria.Text),produtoAtivo,
                3, Convert.ToInt32(txtQuantidade.Text));        
            chamarTela.ProdutoAlterarCadastrar();
            MessageBox.Show(" " + Get());
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
