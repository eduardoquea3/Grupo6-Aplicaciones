using CapaEntidad;
using CapaNegocio;
using System;
using System.IO;

namespace CapaPresentacion.Pages.Academico
{
  public partial class Agregar : System.Web.UI.Page
  {
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      if (guardar() != "nothing")
      {
        new NAcademico().agregarA(new EAcademico(id, txttitulo.Text, txtcentro.Text, txtfgrado.Text, guardar()));
        Response.Redirect($"../Academico.aspx?id={id}");
      }
    }

    protected void btnno_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Academico.aspx?id={id}");
    }
    private string guardar()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      string r = "nothing";
      if (fupdf.HasFile)
      {
        r = id.ToString() + "_" + Guid.NewGuid().ToString() + ".pdf";
        string ext = Path.GetExtension(fupdf.FileName);
        string carpetaDestino = Server.MapPath("~/pdf/academico/");
        string rutaCompleta = Path.Combine(carpetaDestino, r);
        if (ext == ".pdf")
          fupdf.SaveAs(rutaCompleta);
      }
      return r;
    }

  }
}