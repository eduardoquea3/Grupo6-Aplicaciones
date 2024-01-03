using CapaNegocio;
using CapaNegocio.Validaciones;
using System;

namespace CapaPresentacion
{
  public partial class RecuperarPass : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnrecuperar_Click(object sender, EventArgs e)
    {
      NLogin cat = new NLogin();
      VLogin vat = new VLogin();
      string pass = cat.password(txtcorreo.Text);
      if (pass == "")
      {
        return;
      }
      else
      {
        vat.mesagePass(pass, txtcorreo.Text);
        Response.Write("<script>alert('Se le envio al correo')</script>");
        Response.Redirect("./Login.aspx");
      }
    }
  }
}