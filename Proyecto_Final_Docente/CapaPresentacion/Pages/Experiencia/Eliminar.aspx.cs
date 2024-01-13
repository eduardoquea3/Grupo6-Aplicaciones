using CapaEntidad;
using CapaNegocio;
using System;

namespace CapaPresentacion.Pages.Experiencia
{
  public partial class Eliminar : System.Web.UI.Page
  {
    public int id, idE;
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        if (Request.QueryString["id"] != null)
        {
          id = int.Parse(Request.QueryString["id"].ToString());
          idE = int.Parse(Request.QueryString["idE"].ToString());
          EExperiencia user = new NExperiencia().obtener(id, idE);
          DateTime inicio = Convert.ToDateTime(user.fInicio);
          DateTime fin = Convert.ToDateTime(user.fFin);
          txtfinicio.Text = inicio.ToString("yyyy-MM-dd");
          txtffin.Text = fin.ToString("yyyy-MM-dd");
          txtcargo.Text = user.cargo;
          txtempresa.Text = user.empresa;
        }
      }
    }
    protected void btnagregar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      idE = int.Parse(Request.QueryString["idE"].ToString());
      new NExperiencia().eliminarE(id, idE);
      Response.Redirect($"../Experiencia.aspx?id={id}");
    }
    protected void btncancelar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"../Experiencia.aspx?id={id}");
    }
  }
}