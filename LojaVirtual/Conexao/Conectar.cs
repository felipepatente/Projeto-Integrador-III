using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Conexao.Properties;


namespace Conexao
{
    public class Conectar
    {
        public SqlConnection GetConexao()
        {
            try
            {
                return new SqlConnection(Settings.Default.stringConexao);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
