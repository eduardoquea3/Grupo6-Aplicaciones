using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
  public class NLogin
  {
    DLogin cat = new DLogin();
    public string agregar(ULogin user)
    {
      return cat.agregar(user);
    }
    public bool validar(string doc, string correo)
    {
      return cat.validar(doc, correo);
    }
    public int login(ULogin user)
    {
      return cat.login(user);
    }
    public string password(string correo)
    {
      return cat.password(correo);
    }
  }
}
