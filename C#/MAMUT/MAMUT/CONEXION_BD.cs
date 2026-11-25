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
    public static class contadores
    {
        public static bool admin_activo { get; set; }
        public static bool sesion_abierta  { get; set; }
        public static string id { get; set; }
        public static string usuario { get; set; }
        public static string nombre  { get; set; }
        public static string apellido_paterno { get; set; }
        public static string apellido_materno { get; set; }
        public static string cargo { get; set; }
        public static int ultimoreporte { get; set; }
        public static string fecha { get; set; }
    }

}

