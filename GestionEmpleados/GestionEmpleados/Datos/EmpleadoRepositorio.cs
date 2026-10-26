using System;
using System.Configuration;
using System.Data.SqlClient;

namespace GestionEmpleados.Datos
{
    public class EmpleadoRepositorio
    {
        public void GuardarEmpleado(string nombre, string puesto)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPractica"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "INSERT INTO EmpleadosGestion (Nombre, Puesto) VALUES (@Nombre, @Puesto)";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Puesto", puesto);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        

    }
}