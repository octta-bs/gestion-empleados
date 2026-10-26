using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace GestionEmpleadosMVC.Models
{
    public class EmpleadoRepositorioEF : IEmpleadoRepositorio
    {
        private EmpleadosContext db = new EmpleadosContext();

        public List<Empleado> ObtenerTodos()
        {
            return db.Empleados.ToList();
        }

        public Empleado ObtenerPorId(int id)
        {
            return db.Empleados.Find(id);
        }
        public void Agregar(Empleado empleado)
        {
            db.Empleados.Add(empleado);
            db.SaveChanges();
        }
        public void Actualizar(Empleado empleado)
        {
            db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var empleado = db.Empleados.Find(id);
            db.Empleados.Remove(empleado);
            db.SaveChanges();
        }
    }
}