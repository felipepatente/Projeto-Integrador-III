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
    public partial class FrmClienteConsultarExcluir : Form
    {
        public FrmClienteConsultarExcluir()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteConsultarExcluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteAletarCadastrar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteConsultarExcluir();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteAletarCadastrar();
        }

        private void menuClienteAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteAletarCadastrar();
        }

        private void menuClienteCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteAletarCadastrar();
        }

        private void menuClienteConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteConsultarExcluir();
        }

        private void menuClienteExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.ClienteConsultarExcluir();
        }

        private void menuPedidoAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.PedidoAlterarCadastrar();
        }

        private void menuPedidoCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.PedidoAlterarCadastrar();
        }

        private void menuPedidoConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.PedidoConsultarExcluir();
        }

        private void menuPedidoExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.PedidoConsultarExcluir();
        }

        private void menuProdutoAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
        }

        private void menuProdutoCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoAlterarCadastrar();
        }

        private void menuProdutoConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
        }

        private void menuProdutoExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.ProdutoConsultarExcluir();
        }

        private void menuUsuarioAlterar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioAlterarCadastrar();
        }

        private void menuUsuarioCadastrar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioAlterarCadastrar();
        }

        private void menuUsuarioConsultar_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
        }

        private void menuUsuarioExcluir_Click(object sender, EventArgs e)
        {
            ChamarTela.UsuarioConsultarExcluir();
        }

        private void menuTelaInicial_Click(object sender, EventArgs e)
        {
            ChamarTela.Inicial();
        }
    }
}
