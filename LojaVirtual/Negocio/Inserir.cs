﻿using System;
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
            conexao = conectar.GetConexao();
        }

        public int InserirProduto(string nome, string descricao, decimal preco, decimal desconto, int idCategoria,
            string ativoProduto,int idUsuario, int quantidade, byte[] imagem)
        {
            
            
            int linhasAfetadas;

            try
            {

                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText =
                    "INSERT INTO Produto (nomeProduto, descProduto, precProduto,descontoPromocao,idCategoria,ativoProduto,idUsuario,qtdMinEstoque, imagem) " +
                    "VALUES (@nomeProduto,@descProduto,@precProduto,@descontoPromocao,@idCategoria,@ativoProduto,@idUsuario,@qtdMinEstoque, @imagem);";
                conexao.Open();
                comando.Parameters.Add("@nomeProduto", SqlDbType.NVarChar, 70).Value = nome;
                comando.Parameters.Add("@descProduto", SqlDbType.NVarChar, 50).Value = descricao;
                comando.Parameters.Add("@precProduto", SqlDbType.Decimal).Value = preco;
                comando.Parameters.Add("@descontoPromocao", SqlDbType.Decimal).Value = desconto;
                comando.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                comando.Parameters.Add("@ativoProduto", SqlDbType.NChar, 1).Value = ativoProduto;
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                comando.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = quantidade;
                comando.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = imagem;
                linhasAfetadas = comando.ExecuteNonQuery();
                conexao.Close();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                linhasAfetadas = ex.Number;
            }
            catch (Exception)
            {
                linhasAfetadas = -1;
                //throw;
            }

            return linhasAfetadas;
        }

        public int InserirUsuario(string loginUsuario, string senhaUsuario, string nomeUsuario,
            string tipoPerfil, string usuarioAtivo)
        {

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


        public int InserirCategoria(string nome, string descricao)
        {
            int linhas;
            
            try
            {
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandText = "INSERT INTO Categoria " +
                    "(nomeCategoria, descCategoria) VALUES (@nomeCategoria, @descCategoria);";

                conexao.Open();
                comando.Parameters.Add("@nomeCategoria", SqlDbType.NVarChar, 50).Value = nome;
                comando.Parameters.Add("@descCategoria", SqlDbType.NVarChar, 100).Value = descricao;
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

    }
}
