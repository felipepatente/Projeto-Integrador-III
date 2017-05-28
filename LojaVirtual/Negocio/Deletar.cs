using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexao;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class Deletar
    {
        private SqlConnection conexao;
        private Conectar conectar;

        public Deletar()
        {
            this.conexao = new SqlConnection();
            this.conectar = new Conectar();
            conexao = conectar.GetConexao();
        }

        public int DeletarProduto(int idProduto)
        {
            
            int linhas;

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;
                comando.CommandText = "DELETE FROM Produto WHERE idProduto = @idProduto;";
                conexao.Open();
                linhas = comando.ExecuteNonQuery();
                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception)
            {
                linhas = 0;
                //throw;
            }

            return linhas;
        }

        public int DeletarUsuario(int idUsuario)
        {
            int linhas;

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                comando.CommandText = "DELETE FROM Usuario WHERE idUsuario = @idUsuario;";
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                linhas = linhasAfetadas;
                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception)
            {
                linhas = 0;
                //throw;
            }

            return linhas;
        }

        public int DeletarCategoria(int idCategoria)
        {
            int linhas = 0;
            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.CommandText = "DELETE FROM Categoria WHERE idCategoria = @idCategoria;";
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                linhas = linhasAfetadas;
                conexao.Close();
                conexao.Dispose();
            }
            catch (Exception)
            {
                linhas = 0;
                //throw;
            }

            return linhas;
        }

        public int DeletarEstoque(int idEstoque)
        {
            int linhasAfetadas;
            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = idEstoque;
                comando.CommandText = "DELETE FROM estoque WHERE idProduto = @idProduto;";
                conexao.Open();
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
    }
}
