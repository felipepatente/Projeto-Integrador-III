using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Produto
    {
        private int idProduto;
        private string nomeProduto;
        private string descProduto;
        private decimal precProduto;
        private decimal descontoPromocao;
        private int idCategoria;
        private string ativoProduto;
        private int idUsuario;
        private int qtdMinEstoque;
        private string nomeCategoria;

        public int IdProduto
        {
            get
            {
                return this.idProduto;
            }

            set
            {
                this.idProduto = value;
            }
        }
        public string NomeProduto
        {
            get
            {
                return this.nomeProduto;
            }

            set
            {
                this.nomeProduto = value;
            }
        }
        public string DescProduto
        {
            get
            {
                return this.descProduto;
            }

            set
            {
                this.descProduto = value;
            }
        }
        public decimal PrecProduto
        {
            get
            {
                return this.precProduto;
            }

            set
            {
                this.precProduto = value;
            }
        }
        public decimal DescontoPromocao
        {
            get
            {
                return this.descontoPromocao;
            }

            set
            {
                this.descontoPromocao = value;
            }
        }
        public int IdCategoria
        {
            get
            {
                return this.idCategoria;
            }

            set
            {
                this.idCategoria = value;
            }
        }
        public string AtivoProduto
        {
            get
            {
                return this.ativoProduto;
            }

            set
            {
                this.ativoProduto = value;
            }
        }
        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }

            set
            {
                this.idUsuario = value;
            }
        }
        public int QtdMinEstoque
        {
            get
            {
                return this.qtdMinEstoque;
            }

            set
            {
                this.qtdMinEstoque = value;
            }
        }
        public string NomeCategoria
        {
            get
            {
                return this.nomeCategoria;
            }

            set
            {
                this.nomeCategoria = value;
            }
        }

    }
}
