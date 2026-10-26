using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpleadosMVC.Models
{
    
    public interface IEmpleadoRepositorio
    {
        List<Empleado> ObtenerTodos();
        Empleado ObtenerPorId(int id);
        void Agregar(Empleado empleado);
        void Actualizar(Empleado empleado);
        void Eliminar(int id);
    }
}
