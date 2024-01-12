using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
  public class NRegistro
  {
    DRegistro cat = new DRegistro();

    public URegistro datos(int id)
    {
      return cat.datos(id);
    }
    public List<EUbigeo> departamento()
    {
      return cat.departamento();
    }
    public List<EUbigeo> provincia(string dpto)
    {
      return cat.provincia(dpto);
    }
    public List<EUbigeo> distrito(string dpto, string prov)
    {
      return cat.distrito(dpto, prov);
    }
    public List<ESexo> listarSexo()
    {
      return cat.listarSexo();
    }
    public List<ECivil> listarCivil()
    {
      return cat.listarCivil();
    }
    public List<UDiscapacidad> listarDisc(int id)
    {
      return cat.listarDisc(id);
    }
    public void agregarDisc(UDiscapacidad dic)
    {
      cat.agregarDisc(dic);
    }
    public UDiscapacidad obtenerDisc(int id, int idD)
    {
      return cat.obtenerDisc(id, idD);
    }
    public void eliminarDisc(int id, int idD)
    {
      cat.eliminarDisc(id, idD);
    }
    public void updateDisc(UDiscapacidad dic)
    {
      cat.updateDisc(dic);
    }
    public void ingresarDatosR(URegistro us)
    {
      cat.ingresarDatosR(us);
    }
    public string obtenerUbigeo(EUbigeo us)
    {
      return cat.obtenerUbigeo(us);
    }
    public void actualizarDatosLogin(ULogin us)
    {
      cat.actualizarDatosLogin(us);
    }
  }
}
