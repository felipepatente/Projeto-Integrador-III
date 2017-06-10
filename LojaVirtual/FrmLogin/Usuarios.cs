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
    public partial class Usuarios : Form
    {
        
        public Usuarios()
        {
            InitializeComponent();
        }
        
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count != 0)
            {
                if (dgvUsuario.SelectedRows[0].Cells[0].Value != null)
                {
                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir os dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado != DialogResult.No)
                    {
                        Deletar deletar = new Deletar();
                        Usuario usuario = (dgvUsuario.SelectedRows[0].DataBoundItem as Usuario);
                        int linhas = deletar.DeletarUsuario(usuario.IdUsuario);

                        Mensagem mensagem = new Mensagem(linhas, "usuario","produto");
                        string tipoMensagem = mensagem.GetMensagem();

                        if (tipoMensagem.Equals("d"))
                        {
                            MessageBox.Show("Dado excluido com sucesso");
                            AtualizarGrid();
                        }
                        else
                        {
                            MessageBox.Show(tipoMensagem);
                        }
                    }
                }else
                {
                    MessageBox.Show("Linha selecionada não tem conteúdo");
                }
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (dgvUsuario.SelectedRows.Count != 0)
            {
                Usuario usuarioSelecionado = (dgvUsuario.SelectedRows[0].DataBoundItem as Usuario);

                if (txtSenha.Text == "" || txtLogin.Text == "")
                {
                    MessageBox.Show("* Preencha os campos obrigatórios");
                }else if (txtCodigo.Text == "")
                {
                    MessageBox.Show("É necessario fazer uma consultar e escolher um usuario.");
                }
                else
                {
                    Atualizar atualizar = new Atualizar();
                    string tipoPerfil = sltTipoPerfil.Text.Equals("A") ? "A" : "E";
                    string status = rdbAtivado.Checked ? "1" : "0";

                    int linhas = atualizar.AtualizarUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text, tipoPerfil, status, Convert.ToInt32(txtCodigo.Text));

                    if (linhas != 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso");
                        AtualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Não é permitido alterar o 1 primeiro registro");
                    }
                }
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }
        
        private void AtualizarGrid()
        {
            Consultar consultar = new Consultar();
            dgvUsuario.AutoGenerateColumns = false;
            
            if (consultar.ConsultarUsuario("") != null)
            {
                dgvUsuario.DataSource = null;
                dgvUsuario.DataSource = consultar.ConsultarUsuario("");
                dgvUsuario.Update();
                dgvUsuario.Refresh();
            }
            else
            {
                MessageBox.Show("Tempo de conexão esgotado. Tente novamente");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            dgvUsuario.DataSource = null;

            if (consultar.ConsultarUsuario(txtPesquisar.Text) != null)
            {
                dgvUsuario.DataSource = consultar.ConsultarUsuario(txtPesquisar.Text);
            }else
            {
                MessageBox.Show("Tempo de conexão esgotado. Tente novamente");
            }

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

                if (linhas != 0)
                {
                    MessageBox.Show("Dados inseridos com sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usúario");
                }

            }
        }
        
        private void dgvUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count != 0)
            {
                if (dgvUsuario.SelectedRows[0].Cells[0].Value != null)
                {
                    Usuario usuarioSelecionado = (dgvUsuario.SelectedRows[0].DataBoundItem as Usuario);
                    SetarUsuario(usuarioSelecionado);
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

        private void LimparCampos()
        {
            txtCodigo.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtNome.Text = null;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (!ELetra(txtNome.Text) && txtNome.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de letras");
                txtNome.Text = "";
            }
        }

        private bool ELetra(string texto)
        {
            try
            {
                double numero = Convert.ToDouble(texto);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
