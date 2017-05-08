using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Categoria
    {
        private int idCategoria;
        private string nomeCategoria;
        private string descCategoria;

        public int IdCategoria
        {
            get
            {
                return this.idCategoria;
            }

            set{
                this.idCategoria = value;
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

        public string DescCategoria
        {
            get
            {
                return this.descCategoria;
            }

            set
            {
                this.descCategoria = value;
            }
        }
    }
}
