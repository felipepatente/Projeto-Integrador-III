using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Usuario
    {
        private int idUsuario;
        private string loginUsuario;
        private string senhaUsuario;
        private string nomeUsuario;
        private string tipoPerfil;
        private string usuarioAtivo;

        public int IdUsuario {

            get
            {
                return this.idUsuario;
            }

            set
            {
                this.idUsuario = value;
            }
        }

        public string LoginUsuario
        {
            get
            {
                return this.loginUsuario;
            }

            set
            {
                this.loginUsuario = value;
            }
        }

        public string SenhaUsuario {

            get
            {
                return this.senhaUsuario;
            }

            set
            {
                this.senhaUsuario = value;
            }
        }

        public string NomeUsuario {

            get
            {
                return this.nomeUsuario;
            }

            set
            {
                this.nomeUsuario = value;
            }

        }


        public string TipoPerfil {

            get
            {
                return this.tipoPerfil;
            }

            set
            {
                this.tipoPerfil = value;
            }

        }

        public string UsuarioAtivo {

            get
            {
                return this.usuarioAtivo;
            }

            set
            {
                this.usuarioAtivo = value;
            }
        }
    }
}
