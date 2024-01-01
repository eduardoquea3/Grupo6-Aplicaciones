using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
  public class NCurso
  {
    DCurso cat = new DCurso();

    public List<ECurso> listarCursos(int id)
    {
      return cat.listarCursos(id);
    }
  }
}
