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
using System.IO;

namespace FrmLogin
{
    public partial class FrmProdutoConsultarExcluir : Form
    {
        private ChamarTela chamarTela;
        private byte[] imagem;

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
            
            if (dgvProduto.SelectedRows.Count != 0)
            {
                
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir os dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado != DialogResult.No)
                {
                    Deletar deletar = new Deletar();
                    Produto produtoSelecionado = (dgvProduto.SelectedRows[0].DataBoundItem as Produto);
                    int linhas = deletar.DeletarProduto(produtoSelecionado.IdProduto);

                    if (linhas != 0)
                    {
                        MessageBox.Show("Dados excluidos com sucesso");
                        chamarTela.ProdutoConsultarExcluir();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Não é permitido excluir os 10 primeiros registros");
                    }
                }
                
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }

                
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count != 0)
            {
                Produto produtoSelecionado = (dgvProduto.SelectedRows[0].DataBoundItem as Produto);
                FrmProdutoAlterarCadastrar frmProduto = new FrmProdutoAlterarCadastrar(produtoSelecionado);
                frmProduto.MdiParent = MdiPrincipal.ActiveForm;
                frmProduto.Show();
                //chamarTela.ProdutoAlterarCadastrar();
                Close();
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            dgvProduto.AutoGenerateColumns = false;
            dgvProduto.DataSource = null;

            string opcao;

            if(rdbNome.Checked)
            {
                opcao = "nomeProduto";
            }else
            {
                opcao = "nomeCategoria";
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

        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count != 0)
            {
                if (dgvProduto.SelectedRows[0].Cells["imagem"].Value != null)
                {
                    imagem = new byte[0];
                    imagem = (byte[])(dgvProduto.SelectedRows[0].Cells["imagem"].Value);
                    MostrarFoto(imagem);
                }
            }
        }

        private void MostrarFoto(byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(this.imagem);
                pbProduto.Image = Image.FromStream(mem);
            }else
            {
                pbProduto.Image = null;
            }
        }

        public void MostrarFoto2(byte[] dados)
        {
            if (dados.Length > 0)
            {
                Image img;
                MemoryStream ms = new MemoryStream(dados, 0, dados.Length);
                ms.Write(dados, 0, dados.Length);
                img = Image.FromStream(ms, true);
                pbProduto.Image = img;
            }else
            {
                pbProduto.Image = null;
            }
        }
    }
}
