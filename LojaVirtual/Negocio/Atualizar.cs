using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using Conexao;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class Atualizar
    {
        private Conectar conectar;
        private SqlConnection conexao;

        public Atualizar()
        {
            this.conectar = new Conectar();
            this.conexao = new SqlConnection();
        }

        public void AtualizarProduto(string nomeProduto, string descProduto, decimal precProduto, decimal descontoPromocao,
            int idCategoria, string ativoProduto, int idUsuario, int qtdMinEstoque, int idProduto)
        {
            conexao = conectar.GetConexao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();

                
                comando.Parameters.Add("@nomeProduto", SqlDbType.NVarChar, 70).Value = nomeProduto;
                comando.Parameters.Add("@descProduto", SqlDbType.NVarChar, 500).Value = descProduto;
                comando.Parameters.Add("@precProduto", SqlDbType.Decimal).Value = precProduto;
                comando.Parameters.Add("@descontoPromocao", SqlDbType.Decimal).Value = descontoPromocao;
                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.Parameters.Add("@ativoProduto", SqlDbType.Char, 1).Value = ativoProduto;
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                comando.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = qtdMinEstoque;
                comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

                comando.CommandText = "UPDATE Produto SET nomeProduto = @nomeProduto, descProduto = @descProduto, precProduto = @precProduto, " + 
                    "descontoPromocao = @descontoPromocao, idCategoria = @idCategoria, ativoProduto = @ativoProduto, idUsuario = @idUsuario, qtdMinEstoque = @qtdMinEstoque " +
                    "WHERE idProduto = @idProduto; ";

                conexao.Open();

                int linhasAfetadas = comando.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AtualizarUsuario(string loginUsuario, string senhaUsuario, string nomeUsuario, string tipoPerfil,
            string usuarioAtivo, int idUsuario)
        {

            conexao = conectar.GetConexao();
            int linhas;

            try
            {
                SqlCommand comando = conexao.CreateCommand();

                comando.Parameters.Add("@loginUsuario", SqlDbType.NVarChar, 100).Value = loginUsuario;
                comando.Parameters.Add("@senhaUsuario", SqlDbType.NVarChar, 64).Value = senhaUsuario;
                comando.Parameters.Add("@nomeUsuario", SqlDbType.NVarChar, 50).Value = nomeUsuario;
                comando.Parameters.Add("@tipoPerfil", SqlDbType.Char, 1).Value = tipoPerfil;
                comando.Parameters.Add("@usuarioAtivo", SqlDbType.Char, 1).Value = usuarioAtivo;
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;

                comando.CommandText = "UPDATE Usuario SET loginUsuario = @loginUsuario, senhaUsuario = @senhaUsuario, " +
                    "nomeUsuario = @nomeUsuario, tipoPerfil = @tipoPerfil, usuarioAtivo = @usuarioAtivo " +
                    "WHERE idUsuario = @idUsuario";

                conexao.Open();
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


        public void AtualizarCategoria(int idCategoria, string nome, string descricao)
        {

            conexao = conectar.GetConexao();

            try
            {
                SqlCommand comando = conexao.CreateCommand();

                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.Parameters.Add("@nomeCategoria", SqlDbType.NVarChar, 50).Value = nome;
                comando.Parameters.Add("@descCategoria", SqlDbType.NVarChar, 100).Value = descricao;
                comando.CommandText = "UPDATE Categoria SET nomeCategoria = @nomeCategoria, descCategoria = @descCategoria " +
                    "WHERE idCategoria = @idCategoria;";
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
