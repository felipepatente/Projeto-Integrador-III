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
    public partial class FrmUsuarioConsultarExcluir : Form
    {
        private ChamarTela chamarTela;

        public FrmUsuarioConsultarExcluir()
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
            Usuario usuario = (dgvUsuario.SelectedRows[0].DataBoundItem as Usuario);
            deletar.DeletarUsuario(usuario.IdUsuario);
            
            chamarTela.UsuarioConsultarExcluir();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioAlterarCadastrar();
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            Consultar consultar = new Consultar();
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = consultar.ConsultarUsuario(txtPesquisar.Text);
            dgvUsuario.Refresh();
            dgvUsuario.Update();
            
            //chamarTela.UsuarioConsultarExcluir();
            //Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioAlterarCadastrar();
            Close();
        }

        private void menuUsuarioConsultar_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioConsultarExcluir();
        }
    }
}
