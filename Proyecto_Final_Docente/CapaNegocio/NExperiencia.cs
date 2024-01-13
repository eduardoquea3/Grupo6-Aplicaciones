using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
  public class NExperiencia
  {
    DExperiencia cat = new DExperiencia();
    public List<EExperiencia> datos(int id)
    {
      return cat.datos(id);
    }
    public void agregarE(EExperiencia e)
    {
      cat.agregarE(e);
    }
    public void eliminarE(int id, int idE)
    {
      cat.eliminarE(id, idE);
    }
    public EExperiencia obtener(int id, int idE)
    {
      return cat.obtener(id, idE);
    }
    public void actualizar(EExperiencia a)
    {
      cat.actualizar(a);
    }
  }
}
