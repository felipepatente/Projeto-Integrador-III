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
        
        
        private void tsmiTelaInicial_Click(object sender, EventArgs e)
        {
            chamarTela.Inicial();
        }

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
           chamarTela.Login();
            if (!(Dados.tipoPerfil.Equals("A")))
            {
                tsmiProduto.Enabled = false;
                tsmiUsuario.Enabled = false;
                tsmiCategoria.Enabled = false;
            }
        }

        private void tsmiProduto_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            produto.MdiParent = MdiPrincipal.ActiveForm;
            produto.Show();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiUsuario_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.MdiParent = MdiPrincipal.ActiveForm;
            usuario.Show();
        }

        private void tsmiEstoque_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.MdiParent = MdiPrincipal.ActiveForm;
            estoque.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoriaCrud categoria = new FrmCategoriaCrud();
            categoria.MdiParent = MdiPrincipal.ActiveForm;
            categoria.Show();
        }
    }
    }
