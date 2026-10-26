using GestionEmpleadosMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace GestionEmpleadosMVC.Controllers
{
    public class EmpleadosApiController : ApiController
    {
        private IEmpleadoRepositorio repositorio = new EmpleadoRepositorioEF();
        // GET: EmpleadosApi
       public List<Empleado> Get()
        {
            return repositorio.ObtenerTodos();
        }

        public Empleado Get(int id)
        {
            return repositorio.ObtenerPorId(id);
        }

        public void Post([FromBody] Empleado empleado)
        {
            repositorio.Agregar(empleado);
        }
    }
}