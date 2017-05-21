using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexao;
using Negocio;
using ObjetoTransferencia;

namespace FrmLogin
{
    public partial class FrmCategoriaCrud : Form
    {
        public FrmCategoriaCrud()
        {
            InitializeComponent();
        }

        public FrmCategoriaCrud(bool botaoLigado)
        {
            InitializeComponent();
            btnSalvar.Enabled = botaoLigado;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                Inserir inserir = new Inserir();
                inserir.InserirCategoria(txtNome.Text, txtDescricao.Text);

                txtNome.Text = "";
                txtDescricao.Text = "";
            }else
            {
                MessageBox.Show("* Campos obrigatorios");
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            dtvConsultarCategoria.AutoGenerateColumns = false;
            dtvConsultarCategoria.DataSource = null;
            dtvConsultarCategoria.DataSource = consultar.ConsultarCategoria(txtPesquisar.Text);
            dtvConsultarCategoria.Refresh();
            dtvConsultarCategoria.Update();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (dtvConsultarCategoria.SelectedRows.Count != 0)
            {
                Categoria categoriaSelecionada = (dtvConsultarCategoria.SelectedRows[0].DataBoundItem as Categoria);
                Dados.idCategoria = categoriaSelecionada.IdCategoria;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtvConsultarCategoria.SelectedRows.Count != 0)
            {

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir os dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado != DialogResult.No)
                {
                    Categoria categoriaSelecionado = (dtvConsultarCategoria.SelectedRows[0].DataBoundItem as Categoria);
                    Deletar deletar = new Deletar();
                    int linhasAfetadas = deletar.DeletarCategoria(categoriaSelecionado.IdCategoria);

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Dados excluidos com sucessos");
                        dtvConsultarCategoria.DataSource = null;
                    }else
                    {
                        MessageBox.Show("Erro ao exluir os dados");
                    }
                    
                }
                
            }else
            {
                MessageBox.Show("Nenhuma linha selecionado");
            }   
        }

        private void SetarCampos()
        {
            Categoria categoriaSelecionado = (dtvConsultarCategoria.SelectedRows[0].DataBoundItem as Categoria);
            txtIdCategoria.Text = Convert.ToString(categoriaSelecionado.IdCategoria);
            txtNome.Text = categoriaSelecionado.NomeCategoria;
            txtDescricao.Text = categoriaSelecionado.DescCategoria;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (dtvConsultarCategoria.SelectedRows.Count != 0)
            {
                Atualizar atualizar = new Atualizar();
                int linhas = atualizar.AtualizarCategoria(Convert.ToInt32(txtIdCategoria.Text), txtNome.Text, txtDescricao.Text);

                if (linhas != 0)
                {
                    MessageBox.Show("Dados alterado com sucesso");
                    txtDescricao.Text = "";
                    txtNome.Text = "";
                }else
                {
                    MessageBox.Show("Os 6 primeiros registros não pode ser alterado");
                }

            }
            else
            {
                MessageBox.Show("Nenhuma linha selecionado");
            }
        }
        
        private void dtvConsultarCategoria_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dtvConsultarCategoria.SelectedRows.Count != 0)
            {
                SetarCampos();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
