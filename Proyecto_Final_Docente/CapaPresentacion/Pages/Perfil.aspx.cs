using CapaEntidad;
using CapaNegocio;
using System;

namespace CapaPresentacion.Pages
{
  public partial class WebForm2 : System.Web.UI.Page
  {
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        //id = int.Parse(Request.QueryString["id"].ToString());
        //Usuario(id);
        //Registro(id);
      }
    }

    protected void btnguardar_Click(object sender, EventArgs e)
    {

    }

    public void Usuario(int id)
    {
      ULogin user = new NInicio().datosUsuario(id);
      txtusername.Text = user.username;
      txtname.Text = user.nombre;
      txtapepat.Text = user.apellidoPat;
      txtapemat.Text = user.apellidoMat;
      txttipo.Text = user.tipo;
      txtdocumento.Text = user.documento.ToString();
      txtcorreo.Text = user.correo;
    }
    public void Registro(int id)
    {
      URegistro user = new NRegistro().datos(id);
      if (user != null)
      {
        txtsexo.Text = user.sexo;
        txtestado.Text = user.civil;
        txtdireccion.Text = user.direccion;
        txttelefono.Text = user.telefono;
        txtcelular.Text = user.celular;
        ddldpto.SelectedValue = user.dpto;
        ddlprov.SelectedValue = user.prov;
        ddldistrito.SelectedValue = user.dist;
        txtnacimineto.Text = user.fNac;
        imgPerfil.ImageUrl = user.foto == "" || user.foto == null ? "~/imagenes/user.png" : user.foto;
      }
    }
  }
}