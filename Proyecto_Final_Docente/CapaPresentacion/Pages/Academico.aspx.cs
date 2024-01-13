using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;

namespace CapaPresentacion.Pages
{
  public partial class WebForm3 : System.Web.UI.Page
  {
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          List<EAcademico> user = new NAcademico().datos(id);
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
    }
    protected void btnagregar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"./Academico/Agregar.aspx?id={id}");
    }
  }
}