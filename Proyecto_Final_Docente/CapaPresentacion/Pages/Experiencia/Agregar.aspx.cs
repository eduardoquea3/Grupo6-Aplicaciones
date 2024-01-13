using CapaNegocio;
using System;
using System.IO;

namespace CapaPresentacion.Pages.Experiencia
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
        new NExperiencia().agregarE(new CapaEntidad.EExperiencia(id, txtfinicio.Text, txtffin.Text, txtcargo.Text, txtempresa.Text, guardar()));
        Response.Redirect($"../Experiencia.aspx?id={id}");
      }
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Experiencia.aspx?id={id}");
    }
    private string guardar()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      string r = "nothing";
      if (fucerti.HasFile)
      {
        r = id.ToString() + "_" + Guid.NewGuid().ToString() + ".pdf";
        string ext = Path.GetExtension(fucerti.FileName);
        string carpetaDestino = Server.MapPath("~/pdf/experiencia/");
        string rutaCompleta = Path.Combine(carpetaDestino, r);
        if (ext == ".pdf")
          fucerti.SaveAs(rutaCompleta);
      }
      return r;
    }
  }
}