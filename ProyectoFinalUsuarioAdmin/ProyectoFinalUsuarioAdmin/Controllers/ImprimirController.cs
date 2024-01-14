using CrystalDecisions.CrystalReports.Engine;
using ProyectoFinalUsuarioAdmin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinalUsuarioAdmin.Controllers
{
    public class ImprimirController : Controller
    {
        // GET: Imprimir
        public ActionResult Index()
        {
            List<ModeloVistaPersonalizado> listaDatos;

            using (var bd = new ProyectoFinalEntities2())
            {
                listaDatos = (from u in bd.UsuarioDocente
                              join r in bd.RegistroDocente on u.id equals r.id
                              join s in bd.Sexo on r.sexo equals s.id
                              join e in bd.EstadoCivil on r.estadoCivil equals e.id
                              join td in bd.TipoDocumento on u.tipo equals td.id
                              join ub in bd.Ubigeo on r.ubigeo equals ub.ubigeo1 into tempUbigeo
                              from ub in tempUbigeo.DefaultIfEmpty()
                              select new ModeloVistaPersonalizado
                              {
                                  TipoDocumento = td.tipo,
                                  NumeroDocumento = u.doc.ToString(),
                                  NombreCompleto = u.nombre + " " + u.apeP,
                                  sexo = s.tipo,
                                  estado = e.estado,
                                  direccion = r.direccion,
                                  distrito = ub != null ? ub.distrito : "",
                                  Provencia = ub != null ? ub.prov : "",
                                  Departamento = ub != null ? ub.dpto : ""
                              }).ToList();
            }

            if (listaDatos.Any())
            {
                return View(listaDatos);
            }
            else
            {
                return RedirectToAction("NoDataAvailable"); // Otra acción para manejar la ausencia de datos
            }

        }
        public ActionResult Imprimir()
        {
            List<ModeloVistaPersonalizado> listaDatos;

            using (var bd = new ProyectoFinalEntities2())
            {
                listaDatos = (from u in bd.UsuarioDocente
                              join r in bd.RegistroDocente on u.id equals r.id
                              join s in bd.Sexo on r.sexo equals s.id
                              join e in bd.EstadoCivil on r.estadoCivil equals e.id
                              join td in bd.TipoDocumento on u.tipo equals td.id
                              join ub in bd.Ubigeo on r.ubigeo equals ub.ubigeo1 into tempUbigeo
                              from ub in tempUbigeo.DefaultIfEmpty()
                              select new ModeloVistaPersonalizado
                              {
                                  TipoDocumento = td.tipo,
                                  NumeroDocumento = u.doc.ToString(),
                                  NombreCompleto = u.nombre + " " + u.apeP,
                                  sexo = s.tipo,
                                  estado = e.estado,
                                  direccion = r.direccion,
                                  distrito = ub != null ? ub.distrito : "",
                                  Provencia = ub != null ? ub.prov : "",
                                  Departamento = ub != null ? ub.dpto : ""
                              }).ToList();
            }

            if (listaDatos.Any())
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/Models/Reporte"), "CrystalReport.rpt"));
                rd.SetDataSource(listaDatos);

                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();

                try
                {
                    Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                    stream.Seek(0, SeekOrigin.Begin);

                    return File(stream, "application/pdf", "ModeloVistaPersonalizado.pdf");
                }
                catch (Exception ex)
                {
                    // Manejar la excepción si es necesario
                    return RedirectToAction("Error"); // Puedes redirigir a una acción de manejo de errores
                }
            }
            else
            {
                return RedirectToAction("NoDataAvailable"); // Otra acción para manejar la ausencia de datos
            }
        }
        

    }
}






        
            
        
    
