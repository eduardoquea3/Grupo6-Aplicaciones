using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class UsuarioAdminController : Controller
    {
        // GET: UsuarioAdmin
        public ActionResult Index()
        {
            List<UsuarioAdmin> Usuarios = new List<UsuarioAdmin>();
            using (var bd = new ProyectoFinalEntities2())
            {
                Usuarios = bd.UsuarioAdmin.ToList();
            }


            return View(Usuarios);
        }
        public ActionResult Agregar()
        {
            using (var bd = new ProyectoFinalEntities2())
            {
                var listaUsuarioAdmin = bd.UsuarioAdmin.ToList();
                var cursosItems = listaUsuarioAdmin.Select(c => new SelectListItem { Value = c.PerfilUsuario.ToString(), Text = c.PerfilUsuario }).ToList();
                ViewBag.PerfilUsuario = new SelectList(cursosItems, "Value", "Text");
               

            }
            
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(UsuarioAdmin unusuario)
        {
            using (var bd = new ProyectoFinalEntities2())
            {

                bd.UsuarioAdmin.Add(unusuario);
                bd.SaveChanges();
            }

            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
        {
            UsuarioAdmin UNUsuario = new UsuarioAdmin();
            using (var bd = new ProyectoFinalEntities2())
            {
                UNUsuario = bd.UsuarioAdmin.Where(p => p.idUsuario.Equals(id)).First();

            }
            return View(UNUsuario);
        }
        [HttpPost]

        public ActionResult Editar(UsuarioAdmin uuNUSUARIOAD)
        {
            if (ModelState.IsValid) // Verificar si el modelo es válido
            {
                using (var bd = new ProyectoFinalEntities2())
                {
                    var UsuarioExistente = bd.UsuarioAdmin.FirstOrDefault(p => p.idUsuario == uuNUSUARIOAD.idUsuario);

                    if (UsuarioExistente != null)
                    {
                        // Actualizar los datos del empleado con los datos del modelo recibido desde la vista
                        UsuarioExistente.nombreUsuario = uuNUSUARIOAD.nombreUsuario;
                        UsuarioExistente.contra = uuNUSUARIOAD.contra;
                        UsuarioExistente.apellidoPaterno = uuNUSUARIOAD.apellidoPaterno;
                        UsuarioExistente.apellidoMaterno = uuNUSUARIOAD.apellidoMaterno;
                        UsuarioExistente.nombres = uuNUSUARIOAD.nombres;
                        UsuarioExistente.PerfilUsuario = uuNUSUARIOAD.PerfilUsuario;


                        bd.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }

            // Si hay un error de validación, vuelve a mostrar la vista de edición con el modelo de empleado
            return View(uuNUSUARIOAD);
        }
        public ActionResult Eliminar(int id)
        {
            using (var bd = new ProyectoFinalEntities2())
            {
                UsuarioAdmin uneUsuario = bd.UsuarioAdmin.FirstOrDefault(p => p.idUsuario == id);

                if (uneUsuario != null)
                {
                    bd.UsuarioAdmin.Remove(uneUsuario); // Marcar el elemento como eliminado
                    bd.SaveChanges(); // Guardar los cambios en la base de datos
                }
            }

            return RedirectToAction("Index");
        }
    }

}
