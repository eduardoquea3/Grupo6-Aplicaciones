using CapaNegocio;
using System;

namespace CapaPresentacion.Pages.Curso
{
  public partial class Eliminar : System.Web.UI.Page
  {
    public int id, idC;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["idC"] != null)
        {
          idC = int.Parse(Request.QueryString["idC"].ToString());
          lblcurso.Text = new NCurso().obtenerCurso(idC);
        }
      }
    }

    protected void btnsi_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      idC = int.Parse(Request.QueryString["idC"].ToString());
      new NCurso().eliminarCurso(id, idC);
      Response.Redirect($"../Cursos.aspx?id={id}");
    }

    protected void btnno_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Cursos.aspx?id={id}");
    }
  }
}