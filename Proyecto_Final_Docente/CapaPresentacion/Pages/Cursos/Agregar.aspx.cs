using CapaEntidad;
using CapaNegocio;
using System;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Pages.Cursos
{
  public partial class Agregar : System.Web.UI.Page
  {
    public int id;
    NCurso cat = new NCurso();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          foreach (ECurso i in cat.listarCursos(id))
          {
            cblcurso.Items.Add(new ListItem(i.nombre, i.id.ToString()));
          }
        }
      }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      foreach (ListItem i in cblcurso.Items)
      {
        if (i.Selected)
        {
          //Response.Write($"<script>console.log('{i.Value}')</script>");
          new NCurso().agregarCurso(id, int.Parse(i.Value));
        }
      }
      Response.Redirect($"../Cursos.aspx?id={id}");
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Cursos.aspx?id={id}");
    }
  }
}