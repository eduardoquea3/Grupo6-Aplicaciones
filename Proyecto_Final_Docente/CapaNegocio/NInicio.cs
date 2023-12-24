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
  }
}
