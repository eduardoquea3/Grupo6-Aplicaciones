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
    public void agregarA(EAcademico a)
    {
      cat.agregarA(a);
    }
    public void eliminarA(int id, int idA)
    {
      cat.eliminarA(id, idA);
    }
    public EAcademico obtener(int id, int idA)
    {
      return cat.obtener(id, idA);
    }
    public void actualizar(EAcademico a)
    {
      cat.actualizar(a);
    }
  }
}
