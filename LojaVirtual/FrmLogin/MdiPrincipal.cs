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
    public partial class MdiPrincipal : Form
    {
        private int childFormNumber = 0;
        private ChamarTela chamarTela;
        private string idUsuario;

        public MdiPrincipal()
        {
            chamarTela = new ChamarTela();
            InitializeComponent();
        }

        public MdiPrincipal(string idUsuario)
        {
            chamarTela = new ChamarTela();
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiAlterarProduto_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoAlterarCadastrar();
        }

        private void tsmiCadastrarProduto_Click(object sender, EventArgs e)
        {
            //FrmLogin login = new FrmLogin();
            //Convert.ToInt32(idUsuario)
            //FrmProdutoAlterarCadastrar produto = new FrmProdutoAlterarCadastrar(4);
            //produto.MdiParent = MdiPrincipal.ActiveForm;
            //produto.Show();
            chamarTela.ProdutoAlterarCadastrar();
        }

        private void tsmiConsultarProduto_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
        }

        private void tsmiExcluirProduto_Click(object sender, EventArgs e)
        {
            chamarTela.ProdutoConsultarExcluir();
        }

        private void tsmiAlterarUsuario_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioAlterarCadastrar();
        }

        private void tsmiCadastrarUsuario_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioAlterarCadastrar();
        }

        private void tsmiConsultarUsuario_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioConsultarExcluir();
        }

        private void tsmiExcluirUsuario_Click(object sender, EventArgs e)
        {
            chamarTela.UsuarioConsultarExcluir();
        }

        private void tsmiTelaInicial_Click(object sender, EventArgs e)
        {
            chamarTela.Inicial();
        }

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
            chamarTela.Login();
        }
    }
    }
