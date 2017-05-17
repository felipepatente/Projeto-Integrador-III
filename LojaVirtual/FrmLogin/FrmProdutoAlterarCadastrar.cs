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
            txtIdCategoria.Text = Convert.ToString(id);
        }

        public void Set(string id)
        {
            txtIdCategoria.Text = id; 
        }

        public string Get()
        {
            return txtIdCategoria.Text;
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

            if (ValidarValores())
            {
                int linhas = atualizar.AtualizarProduto(txtNome.Text, txtDescricao.Text, Convert.ToDecimal(txtPreco.Text),
                Convert.ToDecimal(txtDesconto.Text), Convert.ToInt32(txtIdCategoria.Text), ativo,
                Convert.ToInt32(txtIdUsuario.Text), Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtIdProduto.Text));

                if (linhas != 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                }
                else
                {
                    MessageBox.Show("Os 10 primeiros registros não pode ser alterados");
                }
            }

            

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarValores())
            {
                Inserir inserir = new Inserir();
                string produtoAtivo = produtoAtivoSim.Checked ? "1" : "0";

                int linhas = inserir.InserirProduto(txtNome.Text, txtDescricao.Text,
                    Convert.ToDecimal(txtPreco.Text), Convert.ToDecimal(txtDesconto.Text), Convert.ToInt32(txtIdCategoria.Text), produtoAtivo,
                    Dados.idUsuario, Convert.ToInt32(txtQuantidade.Text));

                if (linhas != 0)
                {
                    MessageBox.Show("Dados cadastrado com sucesso");
                    chamarTela.ProdutoAlterarCadastrar();
                    Close();
                }else
                {
                    MessageBox.Show("Erro ao cadastro produto");
                }

            }
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
            txtIdUsuario.Text = Convert.ToString(Dados.idUsuario);
        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            FrmCategoriaCrud frmCategoria = new FrmCategoriaCrud();
            frmCategoria.ShowDialog();
        }
        
        private void txtNome_Click(object sender, EventArgs e)
        {
            if (Dados.idCategoria != 0)
            {
                txtIdCategoria.Text = Convert.ToString(Dados.idCategoria);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarValores()
        {
            bool estaValido = true;
            
            if (txtDesconto.Text == "")
            {
                txtDesconto.Text = "0";
            }

            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = " ";
            }

            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "0";
            }

            if (txtIdCategoria.Text == "")
            {
                txtIdCategoria.Text = "1";
            }

            if (txtPreco.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatórios");
                estaValido = false;
            }
            
            return estaValido;
        }

        private bool ValidarNumero(string numero)
        {
            bool eNumero = true;

            try
            {
                decimal num = decimal.Parse(numero);
            }
            catch (Exception)
            {

                eNumero = false;
            }

            return eNumero;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            if(!ValidarNumero(txtPreco.Text) && txtPreco.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtPreco.Text = "0";
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarNumero(txtDesconto.Text) && txtDesconto.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtDesconto.Text = "0";
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarNumero(txtQuantidade.Text) && txtQuantidade.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtQuantidade.Text = "0";
            }
        }
    }
}
