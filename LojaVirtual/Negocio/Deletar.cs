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
        }

        public void DeletarProduto(int idProduto)
        {
            conexao = conectar.GetConexao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;
                comando.CommandText = "DELETE FROM Produto WHERE idProduto = @idProduto;";
                conexao.Open();

                int linhasAfetadas = comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarUsuario(int idUsuario)
        {

            conexao = conectar.GetConexao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                comando.CommandText = "DELETE FROM Usuario WHERE idUsuario = @idUsuario;";
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarCategoria(int idCategoria)
        {

            conexao = conectar.GetConexao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.CommandText = "DELETE FROM Categoria WHERE idCategoria = @idCategoria;";
                conexao.Open();
                int linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
