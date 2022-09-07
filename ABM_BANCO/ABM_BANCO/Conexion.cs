using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ABM_BANCO
{
    public class Conexion
    {
       
        SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-E4M69B29\SQLEXPRESS;Initial Catalog=BANCO;Integrated Security=True");
       

        public DataTable consultarBD(string nombreSP)
        {
            
            conexion.Open();
            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            DataTable tabla = new DataTable();
            

            comando.CommandType = CommandType.StoredProcedure;

            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;

        }

        public int ActualizarBD(string nombreSP, List<Parametros> lista)
        {
            int filasAfectas = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (Parametros param in lista)
            {
                comando.Parameters.AddWithValue(param.Nombre, param.Valor);

            }
            filasAfectas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectas;
        }

       


    }
}
