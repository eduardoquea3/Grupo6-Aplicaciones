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
    public class ImprimirDetalleController : Controller
    {
        // GET: ImprimirDetalle
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
        public ActionResult ImprimirDetalle()
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
            }

            if (docentes.Any())
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/Models/Report"), "CrystalReport1.rpt"));
                rd.SetDataSource(docentes);

                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();

                try
                {
                    Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                    stream.Seek(0, SeekOrigin.Begin);

                    return File(stream, "application/pdf", "ConsultaPersonalizadoDocente.pdf");
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


