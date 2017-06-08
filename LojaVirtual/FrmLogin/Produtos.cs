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
using System.IO;


namespace FrmLogin
{
    public partial class Produtos : Form
    {
        private byte[] imagem;
        private int idCategorias;

        public Produtos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (dgvProduto.SelectedRows.Count != 0)
            {
                if (dgvProduto.SelectedRows[0].Cells[0].Value != null)
                {

                    DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir os dados?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    int linhas;
                    if (resultado != DialogResult.No)
                    {
                        Deletar deletar = new Deletar();
                        Produto produtoSelecionado = (dgvProduto.SelectedRows[0].DataBoundItem as Produto);
                        int linhasEstoque = deletar.DeletarEstoque(produtoSelecionado.IdProduto);
                        linhas = deletar.DeletarProduto(produtoSelecionado.IdProduto);

                        Mensagem mensagem = new Mensagem(linhas, "produto");
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
                }
                else
                {
                    MessageBox.Show("A linha selecionada esta sem valores. Sem exclusão");
                }
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count != 0)
            {
                Produto produtoSelecionado = (dgvProduto.SelectedRows[0].DataBoundItem as Produto);
                AtualizarProduto();
                AtualizarGrid();
            }else
            {
                MessageBox.Show("Nenhuma linha selecionada");
            }
        }

        private string VerOpcao()
        {
            string opcao = "nomeProduto";

            if (rdbCategoria.Checked)
            {
                opcao = "nomeCategoria";
            }

            return opcao;
        }

        private void ConsultarProduto()
        {
            Consultar consultar = new Consultar();
            dgvProduto.AutoGenerateColumns = false;
            
            string opcao = VerOpcao();
            
            if (consultar.ConsultarProduto(opcao, txtPesquisar.Text) != null)
            {
                dgvProduto.DataSource = null;
                dgvProduto.DataSource = consultar.ConsultarProduto(opcao, txtPesquisar.Text);
            }
            else
            {
                MessageBox.Show("Tempo esgotado. Tente novamente");
            }
        }

        private void SetarRadios()
        {
            if (VerOpcao().Equals("nomeCategoria"))
            {
                rdbCategoria.Checked = true;
            }
            else if (VerOpcao().Equals("nomeProduto"))
            {
                rdbNome.Checked = true;
            }
            else
            {
                rdbNome.Checked = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProduto();
            SetarRadios();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarValores())
            {
                Inserir inserir = new Inserir();
                string produtoAtivo = produtoAtivoSim.Checked ? "1" : "0";
                this.imagem = TratarImagem();
                int linhas = inserir.InserirProduto(txtNome.Text, txtDescricao.Text,
                    Convert.ToDecimal(txtPreco.Text), Convert.ToDecimal(txtDesconto.Text), this.idCategorias, produtoAtivo,
                    Dados.idUsuario, Convert.ToInt32(txtQuantidade.Text), this.imagem);
                
                if (linhas == 3609)
                {
                    MessageBox.Show("Falha na hora de cadastrar. A imagem excedeu o limite de tamanho de 300kb");
                }
                else if(linhas > 0)
                {
                    MessageBox.Show("Dados cadastrado com sucesso");
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto");
                }
            }
        }

        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count != 0)
            {
                if (dgvProduto.SelectedRows[0].Cells["imagem"].Value != null)
                {
                    imagem = new byte[0];
                    imagem = (byte[])(dgvProduto.SelectedRows[0].Cells["imagem"].Value);
                    Produto produtoSelecionado = (dgvProduto.SelectedRows[0].DataBoundItem as Produto);
                    SetarProduto(produtoSelecionado);
                    SetarRadios();
                }
            }
        }

        private void SetarProduto(Produto produto)
        {

            txtNome.Text = produto.NomeProduto;
            txtDescricao.Text = produto.DescProduto;
            txtPreco.Text = Convert.ToString(produto.PrecProduto);
            txtDesconto.Text = Convert.ToString(produto.DescontoPromocao);
            cbCategoria.Text = produto.NomeCategoria;
            txtQuantidade.Text = Convert.ToString(produto.QtdMinEstoque);
            
            if (produto.AtivoProduto.Equals("1"))
            {
                produtoAtivoSim.Checked = true;
            }
            else
            {
                produtoAtivoNao.Checked = true;
            }

            txtIdUsuario.Text = Convert.ToString(produto.IdUsuario);
            txtQuantidade.Text = Convert.ToString(produto.QtdMinEstoque);
            txtIdProduto.Text = Convert.ToString(produto.IdProduto);
            if (produto.Imagem.Length > 0)
            {
                //MemoryStream mem = new MemoryStream(produto.Imagem);
                //pbProduto.Image = Image.FromStream(mem);
                //this.imagem = produto.Imagem;
                MostrarFoto(produto.Imagem);
            }
            else
            {
                pbProduto.Image = null;
            }

        }

        private void MostrarFoto(byte[] dados)
        {
            if (dados.Length > 0)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(this.imagem);
                    pbProduto.Image = Image.FromStream(mem);
                }
                catch (Exception)
                {

                    MessageBox.Show("Mensagem não encontrada");
                }
            }else
            {
                pbProduto.Image = null;
            }
        }
        
        //Pesquisar Categoria
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            FrmCategoriaCrud frmCategoria = new FrmCategoriaCrud();
            frmCategoria.ShowDialog();
        }

        private void AtualizarProduto()
        {
            Atualizar atualizar = new Atualizar();

            string ativo;
            if (produtoAtivoSim.Checked)
            {
                ativo = "1";
            }else
            {
                ativo = "0";
            }

            if (ValidarValores())
            {

                this.imagem = TratarImagem();
                int linhas = atualizar.AtualizarProduto(txtNome.Text, txtDescricao.Text, Convert.ToDecimal(txtPreco.Text),
                Convert.ToDecimal(txtDesconto.Text), this.idCategorias, ativo,
                Convert.ToInt32(txtIdUsuario.Text), Convert.ToInt32(txtQuantidade.Text), Convert.ToInt32(txtIdProduto.Text), this.imagem);

                if (linhas == 3609)
                {
                    MessageBox.Show("Falha na hora de atualizar. A imagem excedeu o limite de tamanho de 300kb ou\n" +
                       "esse registro não pode ser alterado");
                }else if(linhas > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso");
                    LimparCampos();
                }else
                {
                    MessageBox.Show("Error ao atualizar produtos");
                }
                
            }
            
        }

        private byte[] TratarImagem()
        {
            byte[] bytes;
            if (pbProduto.Image != null)
            {
                Image img = pbProduto.Image as Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    bytes = ms.ToArray();
                }
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bytes = ms.ToArray();
                }
            }
            return bytes;
        }

        private bool ValidarValores()
        {
            bool estaValido = true;

            if (txtDesconto.Text == "")
            {
                txtDesconto.Text = "0";
            }

            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = " ";
            }

            if (txtQuantidade.Text == "")
            {
                txtQuantidade.Text = "0";
            }

            
            if (cbCategoria.SelectedValue == null)
            {
                this.idCategorias = 1;
            }
            else if (cbCategoria.SelectedValue != null)
            {
                this.idCategorias = Convert.ToInt32(cbCategoria.SelectedValue);
            }else
            {
                estaValido = false;
            }
            
            if (txtPreco.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Campos com * são obrigatórios");
                estaValido = false;
            }

            return estaValido;
        }

        private bool ValidarNumero(string numero)
        {
            bool eNumero = true;

            try
            {
                decimal num = decimal.Parse(numero);
            }
            catch (Exception)
            {

                eNumero = false;
            }

            return eNumero;
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarNumero(txtPreco.Text) && txtPreco.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtPreco.Text = "0";
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarNumero(txtDesconto.Text) && txtDesconto.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtDesconto.Text = "0";
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarNumero(txtQuantidade.Text) && txtQuantidade.Text != "")
            {
                MessageBox.Show("Só é permitida a entrada de números");
                txtQuantidade.Text = "0";
            }
        }

        public void MostrarFoto2(byte[] dados)
        {
            if (dados.Length > 0)
            {
                Image img;
                MemoryStream ms = new MemoryStream(dados, 0, dados.Length);
                ms.Write(dados, 0, dados.Length);
                img = Image.FromStream(ms, true);
                pbProduto.Image = img;
            }else
            {
                pbProduto.Image = null;
            }
        }

        private void btnFoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagem (*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    this.imagem = File.ReadAllBytes(ofd.FileName);
                    MostrarFoto(imagem);
                }
                else
                {
                    this.imagem = new byte[0];
                    MessageBox.Show("Arquivo Inválido! Tente novamente...");
                }
            }
        }

        private void LimparCampos()
        {
            txtIdUsuario.Text = null;
            txtNome.Text = null;
            txtDescricao.Text = null;
            txtPreco.Text = null;
            txtDesconto.Text = null;
            txtQuantidade.Text = null;
            txtIdProduto.Text = null;
            pbProduto.Image = null;
        }

        private void AtualizarGrid()
        {
            ConsultarProduto();
            dgvProduto.Update();
            dgvProduto.Refresh();
        }

        private void cbCategoria_Click(object sender, EventArgs e)
        {
            Consultar consultar = new Consultar();
            DataTable dt = new DataTable();
            dt.Load(consultar.ConsultarCategoriaNome());
            
            cbCategoria.ValueMember = "idCategoria";
            cbCategoria.DisplayMember = "nomeCategoria";            
            cbCategoria.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbCategoria.SelectedValue);
        }
    }
}
