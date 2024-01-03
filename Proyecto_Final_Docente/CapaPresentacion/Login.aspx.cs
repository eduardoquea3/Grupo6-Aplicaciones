using CapaEntidad;
using CapaNegocio;
using CapaNegocio.Validaciones;
using System;

namespace CapaPresentacion
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        btnregistro.Attributes.Remove("onclick");
      }
    }

    VLogin cat = new VLogin();
    NLogin data = new NLogin();
    protected void btnregistro_Click(object sender, EventArgs e)
    {
      bool val = data.validar(new ULogin(int.Parse(txtdocumento.Text), txtcorreo.Text));
      if (val)
      {
        string username = cat.PrimaryWord(txtnombre.Text) + " ";
        data.agregar(new ULogin(
            cat.Capitalize(txtnombre.Text), cat.Capitalize(txtpaterno.Text),
            cat.Capitalize(txtmaterno.Text),
            cat.Capitalize(username + txtpaterno.Text),
            ddltipo.SelectedValue, int.Parse(txtdocumento.Text),
            txtcorreo.Text, txtpassword.Text)
            );
        mesage("Se creo la cuenta correctamente");
      }
      else
      {
        mesage("Un usuario ya uso el documento o el correo");
      }
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
      int id = data.login(new ULogin(txtcorreo2.Text, txtpassword2.Text));
      if (id >= 0)
      {
        Response.Redirect($"/Pages/Inicio.aspx?id={id}");
      }
      else
        mesage("El correo o contraseña son invalidos");
    }
    public void mesage(string data)
    {
      Response.Write($"<script>alert('{data}')</script>");
    }

    protected void lbpass_Click(object sender, EventArgs e)
    {
      Response.Redirect("./RecuperarPass.aspx");
    }
  }
}