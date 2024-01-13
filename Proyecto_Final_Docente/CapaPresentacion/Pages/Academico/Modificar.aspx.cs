using CapaEntidad;
using CapaNegocio;
using System;
using System.IO;

namespace CapaPresentacion.Pages.Academico
{
  public partial class Modificar : System.Web.UI.Page
  {
    public int id, idA;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          idA = int.Parse(Request.QueryString["idA"].ToString());
          EAcademico user = new NAcademico().obtener(id, idA);
          DateTime f = Convert.ToDateTime(user.fGrado);
          txtcentro.Text = user.centro;
          txtfgrado.Text = f.ToString("yyyy-MM-dd");
          txttitulo.Text = user.titulo;
        }
      }
    }

    protected void btnno_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        id = int.Parse(Request.QueryString["id"].ToString());
        Response.Redirect($"../Academico.aspx?id={id}");
      }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        if (guardar() != "nothing")
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          idA = int.Parse(Request.QueryString["idA"].ToString());
          new NAcademico().actualizar(new EAcademico(id, idA, txttitulo.Text, txtcentro.Text, txtfgrado.Text, guardar()));
          Response.Redirect($"../Academico.aspx?id={id}");
        }
      }
    }
    private string guardar()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      idA = int.Parse(Request.QueryString["idA"].ToString());
      EAcademico user = new NAcademico().obtener(id, idA);
      string r = user.pdf;
      if (fupdf.HasFile)
      {
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