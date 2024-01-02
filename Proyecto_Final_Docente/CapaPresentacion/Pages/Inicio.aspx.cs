using System;

namespace CapaPresentacion.Pages
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    public int id;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        //id = int.Parse(Request.QueryString["id"].ToString());
        //ULogin user = new NInicio().datosUsuario(id);
        //lblnombre.Text = user.nombre;
        //lblapellido.Text = user.apellidoPat + " " + user.apellidoMat;
        //lbluser.Text = user.username;
        //lblcorreo.Text = user.correo;
        //lbltipo.Text = user.tipo;
        //lbldocumento.Text = user.documento.ToString();
      }
    }
  }
}
