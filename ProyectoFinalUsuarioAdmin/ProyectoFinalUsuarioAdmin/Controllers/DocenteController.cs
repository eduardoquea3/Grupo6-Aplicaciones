using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class DocenteController : Controller
    {

        public ActionResult Index()
        {
            List<ConsultaPersonalizadoDocente> docentes;
            using (var bd = new ProyectoFinalEntities2())
            {
                docentes = (from u in bd.UsuarioDocente
                            join r in bd.RegistroDocente on u.id equals r.id
                            join s in bd.Sexo on r.sexo equals s.id
                            join e in bd.EstadoCivil on r.estadoCivil equals e.id
                            join td in bd.TipoDocumento on u.tipo equals td.id
                            select new ConsultaPersonalizadoDocente
                            {
                                TipoDocumento = td.tipo,
                                NumeroDocumento = u.doc.ToString(),
                                NombreCompleto = u.nombre + " " + u.apeP,
                                sexo = s.tipo,
                                EstadoCivil = e.estado,
                                PrecioXHora = r.precio_Hora.ToString()
                            }).ToList();
                return View(docentes);
            }
        }
    }
}