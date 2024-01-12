using CapaNegocio;
using System;

namespace CapaPresentacion.Pages
{
  public partial class NewPass : System.Web.UI.Page
  {
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btncambiar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      new NInicio().newpass(id, txtpass.Text, txtnewpass.Text);
      Response.Redirect($"./Perfil.aspx?id={id}");
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
      id = int.Parse(Request.QueryString["id"].ToString());
      Response.Redirect($"./Perfil.aspx?id={id}");
    }
  }
}