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

        public void InserirProduto(string nome, string descricao, decimal preco, decimal desconto, int idCategoria,
            string ativoProduto,int idUsuario, int quantidade)
        {
            Conectar con = new Conectar();
            SqlConnection conexao = new SqlConnection();
            conexao = con.GetConexao();

            try
            {
                conexao.Open();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText =
                    "INSERT INTO Produto (nomeProduto, descProduto, precProduto,descontoPromocao,idCategoria,ativoProduto,idUsuario,qtdMinEstoque) " +
                    "VALUES (@nomeProduto,@descProduto,@precProduto,@descontoPromocao,@idCategoria,@ativoProduto,@idUsuario,@qtdMinEstoque);";

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

    }
}
