using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionEmpleadosMVC.Models
{
    [Table("EmpleadosGestion")]
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
    }
}