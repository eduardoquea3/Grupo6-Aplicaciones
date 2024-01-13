using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
  public class NCurso
  {
    DCurso cat = new DCurso();

    public List<ECurso> listarCursos(int id)
    {
      return cat.listarCursos(id);
    }
    public List<CursoD> listaCursosD(int id)
    {
      return cat.listarCursosD(id);
    }
    public void agregarCurso(int id, int idC)
    {
      cat.agregarCurso(id, idC);
    }
    public void eliminarCurso(int id, int idC)
    {
      cat.eliminarCurso(id, idC);
    }
    public string obtenerCurso(int id)
    {
      return cat.obtenerCurso(id);
    }
  }
}
