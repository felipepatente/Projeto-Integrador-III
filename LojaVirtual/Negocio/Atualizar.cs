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
            conexao = conectar.GetConexao();
        }

        public int AtualizarProduto(string nomeProduto, string descProduto, decimal precProduto, decimal descontoPromocao,
            int idCategoria, string ativoProduto, int idUsuario, int qtdMinEstoque, int idProduto, byte[] imagem)
        {
            int linhas;

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
                comando.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = imagem;

                comando.CommandText = "UPDATE Produto SET nomeProduto = @nomeProduto, descProduto = @descProduto, precProduto = @precProduto, " + 
                    "descontoPromocao = @descontoPromocao, idCategoria = @idCategoria, ativoProduto = @ativoProduto, idUsuario = @idUsuario, qtdMinEstoque = @qtdMinEstoque, imagem = @imagem " +
                    "WHERE idProduto = @idProduto; ";

                conexao.Open();

                int linhasAfetadas = comando.ExecuteNonQuery();
                linhas = linhasAfetadas;
                conexao.Close();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                linhas = ex.Number;
            }
            catch (Exception)
            {
                linhas = -1;
            }
            
            return linhas;
        }

        public int AtualizarUsuario(string loginUsuario, string senhaUsuario, string nomeUsuario, string tipoPerfil,
            string usuarioAtivo, int idUsuario)
        {
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
                conexao.Dispose();
            }
            catch (Exception)
            {
                linhas = 0;
                //throw;
            }

            return linhas;
            
        }


        public int AtualizarCategoria(int idCategoria, string nome, string descricao)
        {
            int linhasAfetadas;

            try
            {
                SqlCommand comando = conexao.CreateCommand();

                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.Parameters.Add("@nomeCategoria", SqlDbType.NVarChar, 50).Value = nome;
                comando.Parameters.Add("@descCategoria", SqlDbType.NVarChar, 100).Value = descricao;
                comando.CommandText = "UPDATE Categoria SET nomeCategoria = @nomeCategoria, descCategoria = @descCategoria " +
                    "WHERE idCategoria = @idCategoria;";
                conexao.Open();
                linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
                conexao.Dispose();

            }
            catch (Exception)
            {
                linhasAfetadas = 0;
                //throw;
            }

            return linhasAfetadas;
        }

        public int AtualizarEstoque(int idProduto, int quantidade)
        {
            int linhasAfetadas;
            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;
                comando.Parameters.Add("@qtdProdutoDisponivel", SqlDbType.Int).Value = quantidade;
                comando.CommandText = "UPDATE estoque SET qtdProdutoDisponivel = @qtdProdutoDisponivel " +
                    "WHERE idProduto = @idProduto;";
                conexao.Open();
                linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
                conexao.Dispose();
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
