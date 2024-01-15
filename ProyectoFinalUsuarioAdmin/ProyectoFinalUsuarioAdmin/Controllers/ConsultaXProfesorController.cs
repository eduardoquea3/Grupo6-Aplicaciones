using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class ConsultaXProfesorController : Controller
    {
        // GET: ConsultaXProfesor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ConsultaPorProfesor(int idProfesor)
        {
            List<ConsultaProfesorResultado> resultados;

            using (var bd = new ProyectoFinalEntities2())
            {
                resultados = (from u in bd.UsuarioDocente
                              join r in bd.RegistroDocente on u.id equals r.id
                              join ub in bd.Ubigeo on r.ubigeo equals ub.ubigeo1
                              where u.id == idProfesor
                              select new ConsultaProfesorResultado
                              {
                                  NombreCompleto = u.nombre + " " + u.apeP,
                                  Distrito = ub.distrito,
                                  Provincia = ub.prov,
                                  Departamento = ub.dpto
                              }).ToList();
            }

            return View(resultados);
        }
    }
}
