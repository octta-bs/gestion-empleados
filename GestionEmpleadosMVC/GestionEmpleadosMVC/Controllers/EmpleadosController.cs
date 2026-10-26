using GestionEmpleadosMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionEmpleadosMVC.Controllers
{
    public class EmpleadosController : Controller
    {
        //cuando si hay Inyección de dependencias (DI)
        private IEmpleadoRepositorio repositorio;

        public EmpleadosController()
        {
            repositorio = new EmpleadoRepositorioEF();
        }

        public EmpleadosController(IEmpleadoRepositorio repositorioInyectado)
        {
            repositorio=repositorioInyectado;
        }

        public ActionResult Index()
        {
            var empleados = repositorio.ObtenerTodos();
            return View(empleados);
        }

        public ActionResult Create()
        {
            return View(new Empleado());
        }
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            repositorio.Agregar(empleado);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var empleado = repositorio.ObtenerPorId(id);
            return View(empleado);
        }
        [HttpPost]
        public ActionResult Edit(Empleado empleado)
        {
            repositorio.Actualizar(empleado);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var empleado = repositorio.ObtenerPorId(id);
            return View(empleado);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorio.Eliminar(id);
            return RedirectToAction("Index");
        }

        //Esto solo aplica cuando no hay Inyección de dependencias (DI)
        // GET: Empleados
        //private EmpleadosContext db = new EmpleadosContext();
        //public ActionResult Index()
        //{
        //    var empelados = db.Empleados.ToList();
        //    return View(empelados);
        //}

        //public ActionResult Create()
        //{
        //    return View(new Empleado());
        //}

        //[HttpPost]
        //public ActionResult Create(Empleado empleado)
        //{
        //    db.Empleados.Add(empleado);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Edit(int id)
        //{
        //    var empleado = db.Empleados.Find(id);
        //    return View(empleado);
        //}
        //[HttpPost]
        //public ActionResult Edit(Empleado empleado)
        //{
        //    db.Entry(empleado).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //public ActionResult Delete(int id)
        //{
        //    var empleado = db.Empleados.Find(id);
        //    return View(empleado);
        //}
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id) {

        //    var empleado = db.Empleados.Find(id);
        //    db.Empleados.Remove(empleado);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}