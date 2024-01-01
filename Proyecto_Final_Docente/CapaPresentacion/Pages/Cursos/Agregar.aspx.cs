using CapaEntidad;
using CapaNegocio;
using System;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Pages.Cursos
{
  public partial class Agregar : System.Web.UI.Page
  {
    NCurso cat = new NCurso();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        foreach (ECurso i in cat.listarCursos(2))
        {
          cblcurso.Items.Add(new ListItem(i.nombre, i.id.ToString()));
        }
      }
    }

    protected void btnagregar_Click(object sender, EventArgs e)
    {
      foreach (ListItem i in cblcurso.Items)
      {
        if (i.Selected)
        {
          Response.Write($"<script>alert('{i.Text}')</script>");
        }
      }
    }
  }
}