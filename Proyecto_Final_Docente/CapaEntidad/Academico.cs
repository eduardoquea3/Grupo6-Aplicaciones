using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
  public class Academico
  {
    public int id { get; set; }
    public int idA { get; set; }
    public string titulo { get; set; }
    public string centro { get; set; }
    public string fGrado { get; set; }
    public string pdf { get; set; }

    public Academico() { }

    public Academico(int id, int idA)
    {
      this.id = id;
      this.idA = idA;
    }

    public Academico(int id, string titulo, string centro, string fGrado, string pdf)
    {
      this.id = id;
      this.titulo = titulo;
      this.centro = centro;
      this.fGrado = fGrado;
      this.pdf = pdf;
    }
  }
}
