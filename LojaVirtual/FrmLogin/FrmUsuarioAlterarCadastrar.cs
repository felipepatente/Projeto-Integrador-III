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
    public partial class FrmUsuarioAlterarCadastrar : Form
    {
        private ChamarTela chamarTela;

        public FrmUsuarioAlterarCadastrar()
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
            chamarTela.UsuarioConsultarExcluir();
            Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Atualizar atualizar = new Atualizar();
            string tipoPerfil =  sltTipoPerfil.Text.Equals("A") ? "A" : "E";
            string status = rdbAtivado.Checked ? "1" : "0";

            atualizar.AtualizarUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text, tipoPerfil, status, Convert.ToInt32(txtCodigo.Text));

            chamarTela.UsuarioAlterarCadastrar();
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioConsultarExcluir();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            string tipoPerfil = sltTipoPerfil.Text.Equals("A") ? "A" : "E";
            string status = rdbAtivado.Checked ? "1" : "0";
            inserir.InserirUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text,tipoPerfil,status);

            chamarTela.UsuarioAlterarCadastrar();
            Close();
        }
    }
}
