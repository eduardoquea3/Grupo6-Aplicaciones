using CapaEntidad;
using CapaNegocio;
using System;
using System.IO;

namespace CapaPresentacion.Pages.Experiencia
{
  public partial class Modificar : System.Web.UI.Page
  {
    public int id, idE;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          idE = int.Parse(Request.QueryString["idE"].ToString());
          EExperiencia user = new NExperiencia().obtener(id, idE);
          DateTime inicio = Convert.ToDateTime(user.fInicio);
          DateTime fin = Convert.ToDateTime(user.fFin);
          txtfinicio.Text = inicio.ToString("yyyy-MM-dd");
          txtffin.Text = fin.ToString("yyyy-MM-dd");
          txtcargo.Text = user.cargo;
          txtempresa.Text = user.empresa;
        }
      }
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        id = int.Parse(Request.QueryString["id"].ToString());
        Response.Redirect($"../Experiencia.aspx?id={id}");
      }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        if (guardar() != "nothing")
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          idE = int.Parse(Request.QueryString["idE"].ToString());
          new NExperiencia().actualizar(new EExperiencia(id, idE, txtcargo.Text, txtempresa.Text, txtfinicio.Text, txtffin.Text, guardar()));
          Response.Redirect($"../Experiencia.aspx?id={id}");
        }
      }
    }

    private void mesage(string data)
    {
      Response.Write($"<script>alert('{data}')</script>");
    }
    private string guardar()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      idE = int.Parse(Request.QueryString["idE"].ToString());
      EExperiencia user = new NExperiencia().obtener(id, idE);
      string r = user.certificado;
      if (fucerti.HasFile)
      {
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