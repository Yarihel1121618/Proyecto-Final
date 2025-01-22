using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public class ConexionDB
    {
        private static string connectionString = "Data Source=YARIHEL\\SQLEXPRESS;Initial Catalog=Inventario;Integrated Security=True;"; 
        public static SqlConnection GetConnection() {
            SqlConnection connection = new SqlConnection(connectionString); 
            try { connection.Open(); Console.WriteLine("Conexión exitosa a la base de datos."); } 
            catch (Exception ex) { Console.WriteLine("Error al conectar a la base de datos: " + ex.Message); }
            return connection; }
    }
}