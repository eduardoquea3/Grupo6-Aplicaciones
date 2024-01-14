using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class ConsultarPerfilController : Controller
    {
        // GET: ConsultarPerfil
        public ActionResult Index(int ? idUsuario)
        {
            if (!idUsuario.HasValue || idUsuario <= 0)
            {
                // Manejar el caso en el que el idUsuario no es válido
                return RedirectToAction("Error");
            }

            using (var bd = new ProyectoFinalEntities2())
            {
                // Buscar el UsuarioAdministrativo por el idUsuario
                var perfil = bd.UsuarioAdmin.SingleOrDefault(u => u.idUsuario == idUsuario);

                if (perfil == null)
                {
                    // Manejar el caso en el que no se encuentra el usuario con el ID proporcionado
                    return RedirectToAction("UsuarioNoEncontrado");
                }

                // Pasa el usuario a la vista
                return View(perfil);
            }
        }
    }
    }

    

