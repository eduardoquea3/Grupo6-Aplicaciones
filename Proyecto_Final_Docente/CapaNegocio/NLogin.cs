using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NLogin
    {
      DLogin cat = new DLogin();
      public string agregar(ULogin user)
      {
        return cat.agregar(user);
      }
      public bool validar(ULogin user)
      {
        return cat.validar(user);
      }
      public int login(ULogin user)
      {
        return cat.login(user);
      }
    }
}
