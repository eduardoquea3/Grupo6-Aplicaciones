using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public class Experiencia
  {
    public int idE { get; set; }
    public int id { get; set; }
    public string fInicio { get; set; }
    public string fFin { get; set; }
    public string cargo { get; set; }
    public string empresa { get; set; }
    public string certificado { get; set; }

    public Experiencia() { }

    public Experiencia(
        int id,
        string fInicio,
        string fFin,
        string cargo,
        string empresa,
        string certificado
    )
    {
      this.id = id;
      this.fInicio = fInicio;
      this.fFin = fFin;
      this.cargo = cargo;
      this.empresa = empresa;
      this.certificado = certificado;
    }

    public Experiencia(
        int id,
        int idE,
        string fInicio,
        string fFin,
        string cargo,
        string empresa
    )
    {
      this.id = id;
      this.idE = idE;
      this.fInicio = fInicio;
      this.fFin = fFin;
      this.cargo = cargo;
      this.empresa = empresa;
    }
  }
}
