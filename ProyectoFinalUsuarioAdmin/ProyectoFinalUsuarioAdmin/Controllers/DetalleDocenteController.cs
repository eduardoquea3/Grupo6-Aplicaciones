using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class DetalleDocenteController : Controller
    {
        // GET: DetalleDocente
        public ActionResult Index(string nombreCompleto)

        {

                if (string.IsNullOrEmpty(nombreCompleto))
                {
                    // Manejar el caso en el que no se proporciona un nombre completo
                    return RedirectToAction("Error"); // Redireccionar a una página de error o manejar de otra forma
                }

                using (var bd = new ProyectoFinalEntities2())
                {
                    var docente = (from u in bd.UsuarioDocente
                                   join r in bd.RegistroDocente on u.id equals r.id
                                   join s in bd.Sexo on r.sexo equals s.id
                                   join e in bd.EstadoCivil on r.estadoCivil equals e.id
                                   join td in bd.TipoDocumento on u.tipo equals td.id
                                   where (u.nombre + " " + u.apeP) == nombreCompleto
                                   select new ConsultaPersonalizadoDocente
                                   {
                                       TipoDocumento = td.tipo,
                                       NumeroDocumento = u.doc.ToString(),
                                       NombreCompleto = u.nombre + " " + u.apeP,
                                       sexo = s.tipo,
                                       EstadoCivil= e.estado,
                                       Telefono=r.telefono,
                                       CorreoElectronico=u.correo,
                                       PrecioXHora=r.precio_Hora.ToString()

                                       
                                       // Otros detalles que desees mostrar
                                   }).FirstOrDefault();

                    if (docente == null)
                    {
                        // Manejar el caso en el que no se encuentra el docente con el nombre proporcionado
                        return RedirectToAction("DocenteNoEncontrado"); // Redireccionar a una página o acción para indicar que no se encontró el docente
                    }

                    return View(docente); // Pasar el ViewModel a la vista
                }
            }

            // Pasar el ViewModel a la vista
        }

    }




   
