using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Conexao;

namespace Negocio
{
    public class Inserir
    {
        private Conectar conectar;
        private SqlConnection conexao;

        public Inserir()
        {
            conectar = new Conectar();
            conexao = new SqlConnection();
        }

        public int InserirProduto(string nome, string descricao, decimal preco, decimal desconto, int idCategoria,
            string ativoProduto,int idUsuario, int quantidade)
        {
            
            conexao = conectar.GetConexao();
            int linhasAfetadas;

            try
            {
                
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText =
                    "INSERT INTO Produto (nomeProduto, descProduto, precProduto,descontoPromocao,idCategoria,ativoProduto,idUsuario,qtdMinEstoque) " +
                    "VALUES (@nomeProduto,@descProduto,@precProduto,@descontoPromocao,@idCategoria,@ativoProduto,@idUsuario,@qtdMinEstoque);";
                conexao.Open();
                comando.Parameters.Add("@nomeProduto", SqlDbType.NVarChar, 70).Value = nome;
                comando.Parameters.Add("@descProduto", SqlDbType.NVarChar, 50).Value = descricao;
                comando.Parameters.Add("@precProduto", SqlDbType.Decimal).Value = preco;
                comando.Parameters.Add("@descontoPromocao", SqlDbType.Decimal).Value = desconto;
                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.Parameters.Add("@ativoProduto", SqlDbType.NChar, 1).Value = ativoProduto;
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                comando.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = quantidade;
                linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {
                linhasAfetadas = 0;
                //throw;
            }
            return linhasAfetadas;
        }

        public int InserirUsuario(string loginUsuario, string senhaUsuario, string nomeUsuario,
            string tipoPerfil, string usuarioAtivo)
        {
            conexao = conectar.GetConexao();
            int linhas;

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO " +
                    "Usuario (loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo) " +
                    "VALUES(@loginUsuario,@senhaUsuario,@nomeUsuario,@tipoPerfil,@usuarioAtivo)";

                conexao.Open();
                comando.Parameters.Add("@loginUsuario", SqlDbType.NVarChar, 100).Value = loginUsuario;
                comando.Parameters.Add("@senhaUsuario", SqlDbType.NVarChar, 64).Value = senhaUsuario;
                comando.Parameters.Add("@nomeUsuario", SqlDbType.NVarChar, 50).Value = nomeUsuario;
                comando.Parameters.Add("@tipoPerfil", SqlDbType.Char, 1).Value = tipoPerfil;
                comando.Parameters.Add("@usuarioAtivo", SqlDbType.Char, 1).Value = usuarioAtivo;
                int linhasAfetadas = comando.ExecuteNonQuery();
                linhas = linhasAfetadas;
                conexao.Close();

            }
            catch (Exception)
            {
                linhas = 0;
                //throw;
            }

            return linhas;
        }


        public void InserirCategoria(string nome, string descricao)
        {

            conexao = conectar.GetConexao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO Categoria " +
                    "(nomeCategoria, descCategoria) VALUES (@nomeCategoria, @descCategoria);";

                conexao.Open();
                comando.Parameters.Add("@nomeCategoria", SqlDbType.NVarChar, 50).Value = nome;
                comando.Parameters.Add("@descCategoria", SqlDbType.NVarChar, 100).Value = descricao;
                int linhas = comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
