using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Prueba2
{
    class ConexionDB
    {
        string cadena = "Data Source=DESKTOP-0LGSNJ6; Initial Catalog=Servicio_Casillero; Integrated Security= True";
        public SqlConnection conectarDB = new SqlConnection();

        //coontructor
        public ConexionDB()
        {
            conectarDB.ConnectionString = cadena;
        }

        //abrir y cerrar conexion
        public void Abrir()
        {
            try
            {
                conectarDB.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD, " +ex.Message);
            }
        }

        public void Cerrar()
        {
            conectarDB.Close();
        }
    }
}
