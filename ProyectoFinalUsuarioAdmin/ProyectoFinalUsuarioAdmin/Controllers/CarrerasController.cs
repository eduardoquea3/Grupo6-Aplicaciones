using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class CarrerasController : Controller
    {
        // GET: Carreras
        public ActionResult Index()
        {

            List<Cursos> unCarrera = new List<Cursos>();
            using (var bd = new ProyectoFinalEntities2())
            {
                unCarrera = bd.Cursos.Include("Carrera").ToList();
            }
            ViewBag.Carreras = new SelectList(unCarrera, "idC");

            return View(unCarrera);
        }

        public ActionResult Agregar()
        {
            using (var bd = new ProyectoFinalEntities2())
            {
                var listaCursos = bd.Cursos.ToList();
                var listaCarreras = bd.Carrera.ToList();
                var cursosItems = listaCursos.Select(c => new SelectListItem { Value = c.curso.ToString(), Text = c.curso }).ToList();
                var carrerasItems = listaCarreras.Select(c => new SelectListItem { Value = c.id.ToString(), Text = c.nombre }).ToList();
                ViewBag.Cursos = new SelectList(cursosItems, "Value", "Text");
                ViewBag.Carreras = new SelectList(carrerasItems, "Value", "Text");

            }
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(Cursos uncurso)
        {
            using (var bd = new ProyectoFinalEntities2())
            {

                bd.Cursos.Add(uncurso);
                bd.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            Cursos uncurso = new Cursos();
            using (var bd = new ProyectoFinalEntities2())
            {
                uncurso = bd.Cursos.Where(p => p.idCurso.Equals(id)).First();

            }
            return View(uncurso);
        }
        [HttpPost]

        public ActionResult Editar(Cursos unCurso)
        {
            if (ModelState.IsValid) // Verificar si el modelo es válido
            {
                using (var bd = new ProyectoFinalEntities2())
                {
                    var CursosExistente = bd.Cursos.FirstOrDefault(p => p.idCurso == unCurso.idCurso);

                    if (CursosExistente != null)
                    {
                        // Actualizar los datos del empleado con los datos del modelo recibido desde la vista
                        CursosExistente.curso = unCurso.curso;
                        CursosExistente.idC = unCurso.idC;
                        bd.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }

            // Si hay un error de validación, vuelve a mostrar la vista de edición con el modelo de empleado
            return View(unCurso);
        }
        public ActionResult Eliminar(int id)
        {
            using (var bd = new ProyectoFinalEntities2())
            {
                Cursos uncurso  = bd.Cursos.FirstOrDefault(p => p.idCurso == id);

                if (uncurso != null)
                {
                    bd.Cursos.Remove(uncurso); // Marcar el elemento como eliminado
                    bd.SaveChanges(); // Guardar los cambios en la base de datos
                }
            }

            return RedirectToAction("Index");
        }
    }

}
    
   



   
