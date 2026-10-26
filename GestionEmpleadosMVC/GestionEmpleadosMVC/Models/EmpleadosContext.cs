using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GestionEmpleadosMVC.Models
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext() : base("ConexionPractica") {

            Database.SetInitializer<EmpleadosContext>(null);
        
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}