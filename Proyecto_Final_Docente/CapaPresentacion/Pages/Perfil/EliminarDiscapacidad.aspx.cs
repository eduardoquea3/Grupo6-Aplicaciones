using CapaEntidad;
using CapaNegocio;
using System;

namespace CapaPresentacion.Pages
{
  public partial class WebForm7 : System.Web.UI.Page
  {
    public int id, idD;
    NRegistro cat = new NRegistro();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          idD = int.Parse(Request.QueryString["idD"].ToString());
          UDiscapacidad user = cat.obtenerDisc(id, idD);
          txtdiscapacidad.Text = user.discapacidad;
          txtdescDiscapacidad.Text = user.descDiscapacidad;
        }
      }
    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      idD = int.Parse(Request.QueryString["idD"].ToString());
      cat.eliminarDisc(id, idD);
      Response.Redirect($"../Perfil.aspx?id={id}");
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Perfil.aspx?id={id}");
    }
  }
}