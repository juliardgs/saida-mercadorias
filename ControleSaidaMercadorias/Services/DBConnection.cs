﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

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
                    instance = new SqlConnection(ConfigurationManager.ConnectionStrings["TESTE_DB"].ConnectionString);
                }
                return instance;
            }
        }
    }
}