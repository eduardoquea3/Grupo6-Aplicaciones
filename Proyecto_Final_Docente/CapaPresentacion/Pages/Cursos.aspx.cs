using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;

namespace CapaPresentacion.Pages
{
  public partial class WebForm5 : System.Web.UI.Page
  {
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        id = int.Parse(Request.QueryString["id"].ToString());
        List<CursoD> user = new NCurso().listaCursosD(id);
        if (user.Count == 0)
        {
          return;
        }
        else
        {
          gvlista.DataSource = user;
          gvlista.DataBind();
        }
      }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"./Cursos/Agregar.aspx?id={id}");
    }
  }
}