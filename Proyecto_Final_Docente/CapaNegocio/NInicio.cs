using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
  public class NInicio
  {
    DInicio cat = new DInicio();

    public ULogin datosUsuario(int id)
    {
      return cat.mostrarUsuario(id);
    }
    public void registro(int id)
    {
      cat.registro(id);
    }
    public void newpass(int id, string pass, string newpass)
    {
      cat.newpass(id, pass, newpass);
    }
  }
}
