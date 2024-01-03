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
  }
}
