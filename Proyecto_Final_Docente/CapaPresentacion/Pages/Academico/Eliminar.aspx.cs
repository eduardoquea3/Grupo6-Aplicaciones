using CapaNegocio;
using System;

namespace CapaPresentacion.Pages.Academico
{
  public partial class Eliminar : System.Web.UI.Page
  {
    public int id, idA;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      idA = int.Parse(Request.QueryString["idA"].ToString());
      new NAcademico().eliminarA(id, idA);
      Response.Redirect($"../Academico.aspx?id={id}");
    }

    protected void btnno_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Academico.aspx?id={id}");
    }
  }
}