using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    public class ConexionBD
    {
        private static string cadena =
            @"Server=AFK®25;
            Database=MAMUT;
            Integrated Security=True;
            TrustServerCertificate=True;";

        public static SqlConnection Conectar()
        {
            return new SqlConnection(cadena);
        }
    }
}

