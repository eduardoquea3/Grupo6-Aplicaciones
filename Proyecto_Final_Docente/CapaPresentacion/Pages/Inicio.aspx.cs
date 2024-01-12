using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CapaPresentacion.Pages
{
  public partial class WebForm1 : System.Web.UI.Page
  {
    public int id;

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          llenarLogin();
          llenarExtras();
          llenarAcademicos();
          llenarExperiencias();
          llenarCursos();
          llenarDiscapacidad();
        }
      }
    }
    public void llenarLogin()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      ULogin user = new NInicio().datosUsuario(id);
      lblnombre.Text = user.nombre;
      lblapellido.Text = user.apellidoPat + " " + user.apellidoMat;
      lbluser.Text = user.username;
      lblcorreo.Text = user.correo;
      lbltipo.Text = user.tipo;
      lbldocumento.Text = user.documento.ToString();
    }
    public void llenarExtras()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      URegistro user = new NRegistro().datos(id);
      if (user == null)
      {
        pnvista.Visible = false;
        lblnopersonales.Visible = true;
        return;
      }
      else
      {
        pnvista.Visible = true;
        lblnopersonales.Visible = false;
        lblsexo.Text = user.sexo;
        lblestado.Text = user.civil;
        lbldirec.Text = user.direccion;
        lbldpto.Text = user.dpto;
        lblprov.Text = user.prov;
        lbldist.Text = user.dist;
        lbltelefono.Text = user.telefono;
        lblcel.Text = user.celular;
        lblfnac.Text = DateTime.ParseExact(user.fNac, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture).Date.ToString("dd/MM/yyyy");
        lblprecio.Text = user.precio.ToString();
      }
    }
    public void llenarAcademicos()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      List<EAcademico> user = new NAcademico().datos(id);
      if (user.Count == 0)
      {
        lblnoacademico.Visible = true;
        return;
      }
      else
      {
        lblnoacademico.Visible = false;
        gvacademicos.DataSource = user;
        gvacademicos.DataBind();
      }
    }
    public void llenarExperiencias()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      List<EExperiencia> user = new NExperiencia().datos(id);
      if (user.Count == 0)
      {
        lblnoexperiencia.Visible = true;
        return;
      }
      else
      {
        lblnoexperiencia.Visible = false;
        gvexpe.DataSource = user;
        gvexpe.DataBind();
      }
    }
    public void llenarCursos()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      List<CursoD> user = new NCurso().listaCursosD(id);
      if (user.Count == 0)
      {
        lblnocursos.Visible = true;
        return;
      }
      else
      {
        lblnocursos.Visible = false;
        gvcurso.DataSource = user;
        gvcurso.DataBind();
      }
    }
    public void llenarDiscapacidad()
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      List<UDiscapacidad> user = new NDiscapacidad().listarDisc(id);
      if (user.Count == 0)
      {
        lblnodiscapacidad.Visible = true;
        return;
      }
      else
      {
        lblnodiscapacidad.Visible = false;
        gvdiscapacidad.DataSource = user;
        gvdiscapacidad.DataBind();
      }
    }

    protected void btnreg_Click(object sender, EventArgs e)
    {
      if (!lblnopersonales.Visible && !lblnodiscapacidad.Visible && !lblnocursos.Visible && !lblnoacademico.Visible && !lblnoexperiencia.Visible)
      {
        id = int.Parse(Request.QueryString["id"].ToString());
        new NInicio().registro(id);
        return;
      }
      Response.Write("<script>alert('No tiene los datos necesarios')</script>");
    }

    protected void btncambiar_Click(object sender, EventArgs e)
    {
      if (Request.QueryString["id"] != null)
      {
        id = int.Parse(Request.QueryString["id"].ToString());
        Response.Redirect($"./NewPass.aspx?id={id}");
      }
      else
      {
        Session["raiz"] = "inicio";
        mesage("Resgistrese");
      }
    }
    private void mesage(string data)
    {
      Response.Write($"<script>alert('{data}')</script>");
    }
  }
}
