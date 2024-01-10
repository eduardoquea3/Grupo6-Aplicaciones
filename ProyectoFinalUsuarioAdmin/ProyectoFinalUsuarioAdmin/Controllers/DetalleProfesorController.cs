using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class DetalleProfesorController : Controller
    {
        // GET: DetalleProfesor
        public ActionResult Index(string nombreCompleto)
        {
            if (string.IsNullOrEmpty(nombreCompleto))
            {
                // Manejar el caso en el que no se proporciona un nombre completo
                return RedirectToAction("Error"); // Redireccionar a una página de error o manejar de otra forma
            }
            using (var bd = new ProyectoFinalEntities2())
            {
                var profesor = (from u in bd.UsuarioDocente
                                join r in bd.RegistroDocente on u.id equals r.id
                                join s in bd.Sexo on r.sexo equals s.id
                                join e in bd.EstadoCivil on r.estadoCivil equals e.id
                                join td in bd.TipoDocumento on u.tipo equals td.id
                                join ub in bd.Ubigeo on r.ubigeo equals ub.ubigeo1 into tempUbigeo
                                from ub in tempUbigeo.DefaultIfEmpty()
                                where (u.nombre + " " + u.apeP) == nombreCompleto
                                select new ModeloVistaPersonalizado
                                {
                                    TipoDocumento = td.tipo,
                                    NumeroDocumento = u.doc.ToString(),
                                    NombreCompleto = u.nombre + " " + u.apeP,
                                    sexo = s.tipo,
                                    estado = e.estado,
                                    direccion=r.direccion,
                                    distrito = ub != null ? ub.distrito : "",
                                    Provencia = ub != null ? ub.prov : "",
                                    Departamento = ub != null ? ub.dpto : ""
                                    // Agrega otras propiedades según tu modelo
                                }).FirstOrDefault();
                if (profesor == null)
                {
                    // Manejar el caso en el que no se encuentra el docente con el nombre proporcionado
                    return RedirectToAction("DocenteNoEncontrado"); // Redireccionar a una página o acción para indicar que no se encontró el docente
                }

                return View(profesor); // Pasar el ViewModel a la vista
            }
        }

            
        
        
    }
}