using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
  public class NAcademico
  {
    DAcademico cat = new DAcademico();
    public List<EAcademico> datos(int id)
    {
      return cat.datos(id);
    }
  }
}
