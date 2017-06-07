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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            if (consultar.ConsultarEstoque() != null)
            {
                dgvEstoque.AutoGenerateColumns = false;
                dgvEstoque.DataSource = null;
                dgvEstoque.DataSource = consultar.ConsultarEstoque();
                dgvEstoque.Refresh();
                dgvEstoque.Update();
            }else
            {
                MessageBox.Show("Tempo de conexão esgotado. Tente novamente");
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            if (dgvEstoque.SelectedRows.Count != 0)
            {
                Atualizar atualizar = new Atualizar();
                int linhas =  atualizar.AtualizarEstoque(Convert.ToInt32(txtIdProduto.Text), Convert.ToInt32(txtQuantidade.Text));

                if (linhas != 0)
                {
                    MessageBox.Show("Dados Atualizados com sucesso");
                    AtualizarGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar dados");
                }

            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void dgvEstoque_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows[0].Cells[0].Value != null)
            {
                SetarCampos();
            }
        }
        
        private void SetarCampos()
        {
            ObjetoTransferencia.Estoque estoqueSelecionado = (dgvEstoque.SelectedRows[0].DataBoundItem as ObjetoTransferencia.Estoque);
            txtIdProduto.Text = Convert.ToString(estoqueSelecionado.Id);
            txtQuantidade.Text = Convert.ToString(estoqueSelecionado.Quantidade);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count != 0)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir os dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado != DialogResult.No)
                {
                    Deletar deletar = new Deletar();
                    int linhas = deletar.DeletarEstoque(Convert.ToInt32(txtIdProduto.Text));

                    if (linhas != 0)
                    {
                        MessageBox.Show("Dados excluidos com sucesso");
                        AtualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir dados");
                    }
                }
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            if (Dados.tipoPerfil.Equals("E"))
            {
                btnDeletar.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarNumero(txtQuantidade.Text) && txtQuantidade.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtQuantidade.Text = "0";
            }
        }

        public bool ValidarNumero(string num)
        {
            try
            {
                int numero = Convert.ToInt32(num);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void AtualizarGrid()
        {
            Consultar consultar = new Consultar();
            dgvEstoque.AutoGenerateColumns = false;
            
            if (consultar.ConsultarEstoque() != null)
            {
                dgvEstoque.DataSource = null;
                dgvEstoque.DataSource = consultar.ConsultarEstoque();
                dgvEstoque.Update();
                dgvEstoque.Refresh();
            }
            else
            {
                MessageBox.Show("Tempo de conexão esgotado. Tente novamente");
            }
        }
    }
}
