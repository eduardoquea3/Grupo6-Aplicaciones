using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.IO;

namespace CapaPresentacion.Pages
{
  public partial class WebForm2 : System.Web.UI.Page
  {
    public int id;
    NInicio cat = new NInicio();
    NLogin bat = new NLogin();
    NRegistro reg = new NRegistro();
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          tabla(id);
          Usuario(id);
          sexo();
          civil();
          Registro(id);
          departamento();
          Registro(id);
        }
      }
    }

    protected void btnguardar_Click(object sender, EventArgs e)
    {
      //if (reg.validarData(txtdocumento.Text, txtcorreo.Text))
      //{
      id = int.Parse(Request.QueryString["id"].ToString());
      string ub = reg.obtenerUbigeo(new EUbigeo(ddldpto.SelectedValue, ddlprov.SelectedValue, ddldistrito.SelectedValue));
      string r = guardar();
      id = int.Parse(Request.QueryString["id"].ToString());
      reg.actualizarDatosLogin(new ULogin(id, txtname.Text,
        txtapepat.Text, txtapemat.Text, txtusername.Text,
        (ddltipo.SelectedIndex + 1).ToString(), txtdocumento.Text, txtcorreo.Text));
      reg.ingresarDatosR(new URegistro(
        id, ddltipo.SelectedIndex + 1, ddlestado.SelectedIndex + 1,
        txtdireccion.Text, ub, txttelefono.Text,
        txtcelular.Text, r, txtnacimineto.Text,
        double.Parse(txtprecio.Text)
        ));
      Registro(id);
      //}
      //else
      //{
      //id = int.Parse(Request.QueryString["id"].ToString());
      //mesage("El documento o el correo ya estan en uso");
      //Response.Redirect($"Perfil.aspx?id={id}");
      //}
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
        DateTime fecha = Convert.ToDateTime(user.fNac);
        ddlsexo.SelectedValue = user.sexo;
        ddlestado.SelectedValue = user.civil;
        txtdireccion.Text = user.direccion;
        txttelefono.Text = user.telefono;
        txtcelular.Text = user.celular;
        ddldpto.SelectedValue = user.dpto;
        ddlprov.SelectedValue = user.prov;
        ddldistrito.SelectedValue = user.dist;
        txtnacimineto.Text = fecha.ToString("yyyy-MM-dd");
        imgPerfil.ImageUrl = user.foto == "" || user.foto == null ? "~/imagenes/user.png" : "~/imagenes/foto/" + user.foto;
        nombrearchivo.Text = user.foto;
        txtprecio.Text = user.precio.ToString();
      }
    }
    protected void ddldpto_SelectedIndexChanged(object sender, EventArgs e)
    {
      provincia();
      distrito();
    }
    protected void ddlprov_SelectedIndexChanged(object sender, EventArgs e)
    {
      distrito();
    }
    protected void btncambiar_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        int id = int.Parse(Request.QueryString["id"].ToString());
        Session["raiz"] = "perfil";
        Response.Redirect($"NewPass.aspx?id={id}");
      }
    }
    private void sexo()
    {
      ddlsexo.DataSource = reg.listarSexo();
      ddlsexo.DataTextField = "tipo";
      ddlsexo.DataBind();
    }
    private void civil()
    {
      ddlestado.DataSource = reg.listarCivil();
      ddlestado.DataTextField = "tipo";
      ddlestado.DataBind();
    }
    private void departamento()
    {
      List<EUbigeo> ub = reg.departamento();
      ddldpto.DataSource = ub;
      ddldpto.DataTextField = "data";
      ddldpto.DataBind();
      provincia();
    }
    private void provincia()
    {
      List<EUbigeo> ub = reg.provincia(ddldpto.SelectedValue);
      ddlprov.DataSource = ub;
      ddlprov.DataTextField = "data";
      ddlprov.DataBind();
      distrito();
    }
    private void distrito()
    {
      List<EUbigeo> ub = reg.distrito(ddldpto.SelectedValue, ddlprov.SelectedValue);
      ddldistrito.DataSource = ub;
      ddldistrito.DataTextField = "data";
      ddldistrito.DataBind();
    }
    private void tabla(int id)
    {
      gvdiscapacidad.DataSource = reg.listarDisc(id);
      gvdiscapacidad.DataBind();
    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        id = int.Parse(Request.QueryString["id"].ToString());
        reg.agregarDisc(new UDiscapacidad(id, txtdiscapacidad.Text, txtdescripcion.Text));
      }
      tabla(id);
    }
    private string guardar()
    {
      string r = imgPerfil.ImageUrl == "~/imagenes/user.png" ? "" : Path.GetFileName(imgPerfil.ImageUrl);
      if (fufoto.HasFile)
      {
        try
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          string ext = Path.GetExtension(fufoto.FileName);
          string carpetaDestino = Server.MapPath("~/imagenes/foto/");
          r = id + ext;
          string rutaCompleta = Path.Combine(carpetaDestino, r);
          string[] extensiones = { ".jpg", ".png", ".jpeg", ".gif" };
          foreach (string extension in extensiones)
          {
            File.Delete(carpetaDestino + txtdocumento.Text + extension);
          }
          fufoto.SaveAs(carpetaDestino + r);
        }
        catch (Exception ex)
        {
          throw new Exception();
        }
      }
      return r;
    }
    private void mesage(string data)
    {
      Response.Write($"<script>alert('{data}')</script>");
    }
  }
}