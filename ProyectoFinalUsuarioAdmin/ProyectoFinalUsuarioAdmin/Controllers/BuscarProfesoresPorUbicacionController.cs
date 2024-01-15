using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class BuscarProfesoresPorUbicacionController : Controller
    {
        // GET: BuscarProfesoresPorUbicacion
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult BuscarProfesoresPorUbicacion(string departamento, string provincia, string distrito)
        {
            List<ConsultaProfesorResultado> resultados;

            using (var bd = new ProyectoFinalEntities2())
            {
                resultados = (from u in bd.UsuarioDocente
                              join r in bd.RegistroDocente on u.id equals r.id
                              join ub in bd.Ubigeo on r.ubigeo equals ub.ubigeo1
                              where (string.IsNullOrEmpty(departamento) || ub.dpto == departamento) &&
                                    (string.IsNullOrEmpty(provincia) || ub.prov == provincia) &&
                                    (string.IsNullOrEmpty(distrito) || ub.distrito == distrito)
                              select new ConsultaProfesorResultado
                              {
                                  NombreCompleto = u.nombre + " " + u.apeP,
                                  Distrito = ub.distrito,
                                  Provincia = ub.prov,
                                  Departamento = ub.dpto
                              }).ToList();
            }

            ViewBag.Departamento = departamento;
            ViewBag.Provincia = provincia;
            ViewBag.Distrito = distrito;

            return View("ResultadoBusqueda", resultados);
        }
    }
}