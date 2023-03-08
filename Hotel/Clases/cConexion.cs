using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel.Clases
{
    internal class cConexion
    {
        //Establecemos la ruta
        static private string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Usuario\Documents\IUE\POO\Proyecto 2\Hotel\Hotel.mdf';Integrated Security=True;Connect Timeout=30";

        //Creamos una instancia de la ruta de la base de datos 
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        //Mertodo para abrie la base de datos
        public SqlConnection AbrirConexion()
        {
            if(Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
            
        }

        //Metodo para cerrar la conexion
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == ConnectionState.Open)
                Conexion.Close();
        return Conexion;
        }
    }
}
