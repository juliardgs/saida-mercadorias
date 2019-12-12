using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleSaidaMercadorias.Services
{
    public sealed class DBConnection
    {
        private static volatile SqlConnection instance;

        private DBConnection() { }

        public static SqlConnection DB_Connection
        {
            get
            {
                if(instance == null)
                {
                    try
                    {
                        instance = new SqlConnection(ConfigurationManager.ConnectionStrings["TESTE_DB"].ConnectionString);

                    }
                    catch
                    {
                        MessageBox.Show("Banco de dados não encontrado!", "Erro de Banco de dados");
                        Environment.Exit(1);
                    }
                }
                return instance;
            }
        }
    }
}
