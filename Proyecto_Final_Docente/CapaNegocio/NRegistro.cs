using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
  public class NRegistro
  {
    DRegistro cat = new DRegistro();

    public URegistro datos(int id)
    {
      return cat.datos(id);
    }
  }
}
