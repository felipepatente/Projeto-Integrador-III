using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Estoque
    {
        private int id;
        private string nomeProduto;
        private int quantidade;

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public string NomeProduto
        {
            get{
                return this.nomeProduto;
            }

            set
            {
                this.nomeProduto = value;
            }
        }
        public int Quantidade
        {
            get
            {
                return this.quantidade;
            }

            set
            {
                this.quantidade = value;
            }
        }
    }
}
