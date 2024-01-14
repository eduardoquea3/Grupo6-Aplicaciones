using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{


    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
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
        public ActionResult Login(string nombreUsuario, string contra, string perfilUsuario)
        {
            // Validación de la existencia de los campos de nombre de usuario y contraseña (se pueden agregar más validaciones según sea necesario)
            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contra))
            {
                ModelState.AddModelError("", "Por favor, complete todos los campos.");
                return View();
            }
            if (perfilUsuario != "Jefatura")
            {
                return RedirectToAction("Index", "Home"); // Retorna la vista de inicio de sesión con un mensaje de error
            }

            // Redireccionar directamente a la página de inicio ("Home")
            return RedirectToAction("Index", "UsuarioAdmin");
        }
    }
}

