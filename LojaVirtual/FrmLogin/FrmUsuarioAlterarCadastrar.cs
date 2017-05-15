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
    public partial class FrmUsuarioAlterarCadastrar : Form
    {
        private ChamarTela chamarTela;

        public void Construtor()
        {
            chamarTela = new ChamarTela();
            InitializeComponent();
        }

        public FrmUsuarioAlterarCadastrar()
        {
            this.Construtor();
        }

        public FrmUsuarioAlterarCadastrar(Usuario usuario)
        {
            this.Construtor();
            SetarUsuario(usuario);
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
            if (txtSenha.Text == "" || txtLogin.Text == "")
            {
                MessageBox.Show("* Preencha os campos obrigatórios");
            }
            else
            {
                Atualizar atualizar = new Atualizar();
                string tipoPerfil = sltTipoPerfil.Text.Equals("A") ? "A" : "E";
                string status = rdbAtivado.Checked ? "1" : "0";

                int linhas = atualizar.AtualizarUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text, tipoPerfil, status, Convert.ToInt32(txtCodigo.Text));

                if (linhas == 0)
                {
                    MessageBox.Show("Não é permitido alterar os 2 primeiros registros");
                }else
                {
                    MessageBox.Show("Dados atualizados com sucesso");
                    chamarTela.UsuarioAlterarCadastrar();
                    Close();
                }
            }
        }

        private void SetarUsuario(Usuario usuario)
        {
            txtCodigo.Text = Convert.ToString(usuario.IdUsuario);
            txtLogin.Text = Convert.ToString(usuario.LoginUsuario);
            txtSenha.Text = Convert.ToString(usuario.SenhaUsuario);
            txtNome.Text = Convert.ToString(usuario.NomeUsuario);
            sltTipoPerfil.Text = usuario.TipoPerfil.Equals("A") ? "A" : "E";
            
            if (usuario.UsuarioAtivo.Equals("True"))
            {
                rdbAtivado.Checked = true;
            }
            else
            {
                rdbDesativado.Checked = true;
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioConsultarExcluir();
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("* Preencha os campos obrigatórios");
            }
            else
            {
                Inserir inserir = new Inserir();
                string tipoPerfil = sltTipoPerfil.Text.Equals("A") ? "A" : "E";
                string status = rdbAtivado.Checked ? "1" : "0";
                int linhas = inserir.InserirUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text, tipoPerfil, status);

                if (linhas == 0)
                {
                    MessageBox.Show("Erro ao cadastrar usúario");
                }else
                {
                    MessageBox.Show("Dados inseridos com sucesso");
                    chamarTela.UsuarioAlterarCadastrar();
                    Close();
                }
                
            }
        }
    }
}
