using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.SqlClient; solo se usa en la primero forma
using System.Configuration;

namespace GestionEmpleados
{
    public partial class AltaEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //primero forma
        //protected void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionPractica"].ConnectionString;

        //    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        //    {
        //        string consulta = "insert into EmpleadosGestion (Nombre, Puesto) values (@Nombre, @Puesto)";

        //        using (SqlCommand comando = new SqlCommand(consulta, conexion))
        //        {
        //            comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
        //            comando.Parameters.AddWithValue("@Puesto", txtPuesto.Text);

        //            conexion.Open();
        //            comando.ExecuteNonQuery();
        //        }

        //    }
        //    //string nombre = txtNombre.Text;
        //    //string puesto = txtPuesto.Text;
        //    //lblMensaje.Text = "Empledo guardado: " + nombre + "-" + puesto;
        //    lblMensaje.Text = "Empledo guardado: " + txtNombre.Text + "-" + txtPuesto.Text;

        //}

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var repositorio = new GestionEmpleados.Datos.EmpleadoRepositorio();
                repositorio.GuardarEmpleado(txtNombre.Text, txtPuesto.Text);

                lblMensaje.Text = "Empleado guardado: " + txtNombre.Text + " - " + txtPuesto.Text;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Ocurrió un error al guardar: " + ex.Message;
            }
        }
    }

}