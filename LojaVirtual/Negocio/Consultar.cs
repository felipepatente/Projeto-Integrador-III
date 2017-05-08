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

        public Consultar()
        {
            this.conectar = new Conectar();
            this.conexao = new SqlConnection();
        }


       public CategoriaColecao ConsultarCategoria(string nome)
        {
            conexao = conectar.GetConexao();
            CategoriaColecao catColecao = new CategoriaColecao();
            

            try
            {
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

                return catColecao;
                
            }
            catch (Exception)
            {

                throw;
            }
        } 
       
       public int ConsultarUsuarioLogin(string login, string senha)
        {
            conexao = conectar.GetConexao();
            UsuarioColecao usuColecao = new UsuarioColecao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@login", SqlDbType.NVarChar, 100).Value = login;
                comando.Parameters.Add("@senha", SqlDbType.NVarChar, 64).Value = senha;
                comando.CommandText = "SELECT loginUsuario, senhaUsuario, idUsuario " +
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
                    linhas = usuario.IdUsuario;
                }
                
                return linhas;
            }
            catch (Exception)
            {

                throw;
            }

        }

       public ProdutoColecao ConsultarProduto(string tipoPesquisa, string pesquisa)
        {
            conexao = conectar.GetConexao();
            ProdutoColecao proColecao = new ProdutoColecao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                
                comando.CommandText = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, " +
                    "nomeCategoria, c.idCategoria, ativoProduto, idUsuario, qtdMinEstoque " +
                    "FROM Produto AS p " +
                    "INNER JOIN Categoria AS c " +
                    "ON c.idCategoria = p.idCategoria " +
                    "WHERE "+ tipoPesquisa +" LIKE '%"+ pesquisa +"%'; ";
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
                    produto.IdUsuario = Convert.ToInt32(meuDataReader["idUsuario"]);
                    produto.QtdMinEstoque = Convert.ToInt32(meuDataReader["qtdMinEstoque"]);
                    proColecao.Add(produto);
                }

                conexao.Close();
                return proColecao;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       public UsuarioColecao ConsultarUsuario(string nome)
        {
            conexao = conectar.GetConexao();
            UsuarioColecao usuColecao = new UsuarioColecao();

            try
            {
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

                return usuColecao;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
