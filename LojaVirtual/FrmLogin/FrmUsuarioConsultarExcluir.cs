using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            chamarTela.UsuarioConsultarExcluir();
            Close();
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
