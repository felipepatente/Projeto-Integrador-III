using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin
{
    public class Mensagem
    {
        private int numero;
        private string tipo;

        public Mensagem(int numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        public string GetMensagem()
        {
            string mensagem;
            if (numero == 3609)
            {
                mensagem = "Não é permitido exluir esse registro";
            }
            else if (numero == 547)
            {
                mensagem = "Exclusão negada. Esta(e) " + tipo +" esta sendo usado(a) em um dos produtos";
            }
            else if (numero > 0)
            {
                mensagem = "d";
            }
            else
            {
                mensagem = "Error ao excluir " + tipo;
            }
            return mensagem;
        }
    }
}
