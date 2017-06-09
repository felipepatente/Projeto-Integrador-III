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
        private string localTabela;
        private string ondeTabela;

        public Mensagem(int numero, string localTabela, string ondeTabela)
        {
            this.numero = numero;
            this.localTabela = localTabela;
            this.ondeTabela = ondeTabela;
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
                mensagem = "Exclusão negada. Esta(e) " + this.localTabela + " esta sendo usado(a) em um dos " + this.ondeTabela;
            }
            else if (numero > 0)
            {
                mensagem = "d";
            }
            else
            {
                mensagem = "Error ao excluir " + this.localTabela;
            }
            return mensagem;
        }
    }
}
