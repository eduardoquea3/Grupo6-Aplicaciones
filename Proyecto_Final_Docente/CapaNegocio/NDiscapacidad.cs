using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
  public class NDiscapacidad
  {
    DRegistro cat = new DRegistro();
    public List<UDiscapacidad> listarDisc(int id)
    {
      return cat.listaDisc(id);
    }
  }
}
