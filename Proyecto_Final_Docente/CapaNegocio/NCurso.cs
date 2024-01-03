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
  }
}
