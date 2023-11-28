using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entities
{
    using System.Data.SqlClient;

    class conexionbd
    {
        //Cadena de Conexion
        string cadena = "Data Source=DESKTOP-6AIFGAG\\SQLEXPRESS;Initial Catalog=SAP_DB;Integrated Security=True";

        public SqlConnection Conectarbd = new SqlConnection();

     
        public conexionbd()
        {
            Conectarbd.ConnectionString=cadena;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " +ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            Conectarbd.Close();
        }
    }

}
