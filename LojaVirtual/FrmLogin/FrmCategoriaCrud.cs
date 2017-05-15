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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.InserirCategoria(txtNome.Text, txtDescricao.Text);

            txtNome.Text = "";
            txtDescricao.Text = "";

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
            Categoria categoriaSelecionada =  (dtvConsultarCategoria.SelectedRows[0].DataBoundItem as Categoria);
            FrmProdutoAlterarCadastrar produto = new FrmProdutoAlterarCadastrar();
            MessageBox.Show("Id: " +categoriaSelecionada.IdCategoria);
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Categoria categoriaSelecionado = (dtvConsultarCategoria.SelectedRows[0].DataBoundItem as Categoria);
            Deletar deletar = new Deletar();
            deletar.DeletarCategoria(categoriaSelecionado.IdCategoria);   
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
            Atualizar atualizar = new Atualizar();
            atualizar.AtualizarCategoria(Convert.ToInt32(txtIdCategoria.Text),txtNome.Text, txtDescricao.Text);
        }
        
        private void dtvConsultarCategoria_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dtvConsultarCategoria.SelectedRows.Count != 0)
            {
                SetarCampos();
            }
            
        }
    }
}
