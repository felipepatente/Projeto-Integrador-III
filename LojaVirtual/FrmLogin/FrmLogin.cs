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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btbEntrar_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            
            int linhas = consultar.ConsultarUsuarioLogin(txtLogin.Text, txtSenha.Text);
            Dados.idUsuario = linhas;       
            
            if (linhas == 0)
            {
                MessageBox.Show("Senha ou Login incorretos");
                txtLogin.Text = "";
                txtSenha.Text = "";
            }else
            {
                Dados.tipoPerfil = consultar.GetTipoPerfil();
                Close();
            }
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Dados.tipoPerfil = "E";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
