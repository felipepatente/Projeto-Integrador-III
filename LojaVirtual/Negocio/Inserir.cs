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

        public void InserirProduto(string nome, string descricao, decimal preco, decimal desconto, int idCategoria,
            string ativoProduto,int idUsuario, int quantidade)
        {
            
            conexao = conectar.GetConexao();
           
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
                comando.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void InserirUsuario(string loginUsuario, string senhaUsuario, string nomeUsuario,
            string tipoPerfil, string usuarioAtivo)
        {
            conexao = conectar.GetConexao();

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
                int linhas = comando.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception)
            {

                throw;
            }

            /*SqlCommand comando = conexao.CreateCommand();
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
                comando.ExecuteNonQuery();
                conexao.Close();*/
        }



    }
}
