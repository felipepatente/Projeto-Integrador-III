using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Conexao;
using ObjetoTransferencia;


namespace Negocio
{
    public class Consultar
    {
        private Conectar conectar;
        private SqlConnection conexao;
        private string tipoPerfil;

        public Consultar()
        {
            this.conectar = new Conectar();
            this.conexao = new SqlConnection();
        }


       public CategoriaColecao ConsultarCategoria(string nome)
        {
            try
            {
                CategoriaColecao catColecao = new CategoriaColecao();
                conexao = conectar.GetConexao();
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@nomeCategoria", SqlDbType.NVarChar, 50).Value = nome;
                comando.CommandText = "SELECT idCategoria, nomeCategoria, descCategoria FROM categoria "+
                    "WHERE nomeCategoria LIKE '%' + @nomeCategoria + '%';";
                conexao.Open();
                
                SqlDataReader meuDataReader = comando.ExecuteReader();
                

                while (meuDataReader.Read())
                {
                    Categoria cat = new Categoria();

                    cat.IdCategoria = Convert.ToInt32(meuDataReader["idCategoria"]);
                    cat.NomeCategoria = Convert.ToString(meuDataReader["nomeCategoria"]);
                    cat.DescCategoria = Convert.ToString(meuDataReader["descCategoria"]);
                    catColecao.Add(cat);
                }

                conexao.Close();
                conexao.Dispose();

                return catColecao;
                
            }
            catch (Exception)
            {
                return null;
                //throw;
            }
        } 
       
       public int ConsultarUsuarioLogin(string login, string senha)
        {
            try
            {
                UsuarioColecao usuColecao = new UsuarioColecao();
                conexao = conectar.GetConexao();
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@login", SqlDbType.NVarChar, 100).Value = login;
                comando.Parameters.Add("@senha", SqlDbType.NVarChar, 64).Value = senha;
                comando.CommandText = "SELECT loginUsuario, senhaUsuario, idUsuario, tipoPerfil " +
                    "FROM Usuario WHERE loginUsuario = @login AND senhaUsuario = @senha;";
                conexao.Open();

                SqlDataReader meuDataReader = comando.ExecuteReader();
                int linhas = 0;

                while (meuDataReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(meuDataReader["idUsuario"]);
                    usuario.LoginUsuario = Convert.ToString(meuDataReader["loginUsuario"]);
                    usuario.SenhaUsuario = Convert.ToString(meuDataReader["senhaUsuario"]);
                    usuario.TipoPerfil = Convert.ToString(meuDataReader["tipoPerfil"]);
                    tipoPerfil = usuario.TipoPerfil;
                    linhas = usuario.IdUsuario;
                }

                conexao.Close();
                conexao.Dispose();
                return linhas;
            }
            catch (Exception)
            {
                return -1;
                //throw;
            }

        }

        public string GetTipoPerfil()
        {
            return tipoPerfil;
        }

       public ProdutoColecao ConsultarProduto(string tipoPesquisa, string pesquisa)
        {
            try
            {
                ProdutoColecao proColecao = new ProdutoColecao();
                conexao = conectar.GetConexao();
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@tipoPesquisa", SqlDbType.NVarChar, 50).Value = tipoPesquisa;
                comando.Parameters.Add("@pesquisa", SqlDbType.NVarChar, 50).Value = pesquisa;
                
                string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, " +
                    "nomeCategoria, c.idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem " +
                    "FROM Produto AS p " +
                    "INNER JOIN Categoria AS c " +
                    "ON c.idCategoria = p.idCategoria " +
                    "WHERE " + tipoPesquisa + " LIKE '%' + @pesquisa + '%';";
                
                comando.CommandText = sql;
                conexao.Open();

                SqlDataReader meuDataReader = comando.ExecuteReader();

                while (meuDataReader.Read())
                {
                    Produto produto = new Produto();
                    produto.IdProduto = Convert.ToInt32(meuDataReader["idProduto"]);
                    produto.NomeProduto = Convert.ToString(meuDataReader["nomeProduto"]);
                    produto.DescProduto = Convert.ToString(meuDataReader["descProduto"]);
                    produto.PrecProduto = Convert.ToDecimal(meuDataReader["precProduto"]);
                    produto.DescontoPromocao = Convert.ToDecimal(meuDataReader["descontoPromocao"]);
                    produto.NomeCategoria = Convert.ToString(meuDataReader["nomeCategoria"]);
                    produto.IdCategoria = Convert.ToInt32(meuDataReader["idCategoria"]);
                    produto.AtivoProduto = Convert.ToString(meuDataReader["ativoProduto"]);

                    if (meuDataReader["idUsuario"] != DBNull.Value)
                    {
                        produto.IdUsuario = Convert.ToInt32(meuDataReader["idUsuario"]);
                    }else
                    {
                        produto.IdUsuario = 1;
                    }

                    produto.QtdMinEstoque = Convert.ToInt32(meuDataReader["qtdMinEstoque"]);
                   // produto.Imagem = (byte[])(meuDataReader["imagem"]);

                    if (meuDataReader["imagem"] != DBNull.Value)
                    {
                        produto.Imagem = (byte[])meuDataReader["imagem"];
                    }
                    else
                    {
                        produto.Imagem = new byte[0];
                    }

                    proColecao.Add(produto);
                }

                conexao.Close();
                conexao.Dispose();

                return proColecao;
            }
            catch (Exception)
            {
                return null;
                //throw;
            }

        }

       public UsuarioColecao ConsultarUsuario(string nome)
        {
            try
            {
                UsuarioColecao usuColecao = new UsuarioColecao();
                conexao = conectar.GetConexao();
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@nomeUsuario", SqlDbType.NVarChar, 50).Value = nome;
                comando.CommandText = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo " +
                "FROM Usuario " +
                "WHERE nomeUsuario LIKE '%' + @nomeUsuario + '%';";
                conexao.Open();

                SqlDataReader meuDataReader = comando.ExecuteReader();
                
                while (meuDataReader.Read())
                {
                    Usuario usu = new Usuario();
                    usu.IdUsuario = Convert.ToInt32(meuDataReader["idUsuario"]);
                    usu.LoginUsuario = Convert.ToString(meuDataReader["loginUsuario"]);
                    usu.SenhaUsuario = Convert.ToString(meuDataReader["senhaUsuario"]);
                    usu.NomeUsuario = Convert.ToString(meuDataReader["nomeUsuario"]);
                    usu.TipoPerfil = Convert.ToString(meuDataReader["tipoPerfil"]);
                    usu.UsuarioAtivo = Convert.ToString(meuDataReader["usuarioAtivo"]);
                    usuColecao.Add(usu);
                }

                conexao.Close();
                conexao.Dispose();
                return usuColecao;
            }
            catch (Exception)
            {
                return null;
                //throw;
            }
        }

       public EstoqueColecao ConsultarEstoque()
        {
            try
            {
                EstoqueColecao estoqueColecao = new EstoqueColecao();
                conexao = conectar.GetConexao();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "SELECT e.idProduto, nomeProduto, qtdProdutoDisponivel " +
                                       "FROM estoque AS e " +
                                        "INNER JOIN Produto AS p " +
                                        "ON e.idProduto = p.idProduto";
                conexao.Open();
                SqlDataReader meuDataReader = comando.ExecuteReader();

                while (meuDataReader.Read())
                {
                    Estoque estoque = new Estoque();
                    estoque.Id = Convert.ToInt32(meuDataReader["idProduto"]);
                    estoque.NomeProduto = Convert.ToString(meuDataReader["nomeProduto"]);
                    estoque.Quantidade = Convert.ToInt32(meuDataReader["qtdProdutoDisponivel"]);
                    estoqueColecao.Add(estoque);
                }

                conexao.Close();
                conexao.Dispose();
                return estoqueColecao;

            }
            catch (Exception)
            {
                return null;
                //throw;
            }
        }

    }
}
