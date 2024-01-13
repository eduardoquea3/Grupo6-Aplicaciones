namespace CapaEntidad
{
  public class EAcademico
  {
    public int id { get; set; }
    public int idA { get; set; }
    public string titulo { get; set; }
    public string centro { get; set; }
    public string fGrado { get; set; }
    public string pdf { get; set; }
    public EAcademico() { }

    public EAcademico(int id, int idA)
    {
      this.id = id;
      this.idA = idA;
    }

    public EAcademico(int id, int idA, string titulo, string centro, string fGrado) : this(id, idA)
    {
      this.titulo = titulo;
      this.centro = centro;
      this.fGrado = fGrado;
    }
    public EAcademico(int id, int idA, string titulo, string centro, string fGrado, string pdf) : this(id, idA)
    {
      this.titulo = titulo;
      this.centro = centro;
      this.fGrado = fGrado;
      this.pdf = pdf;
    }
    public EAcademico(int id, string titulo, string centro, string fGrado, string pdf)
    {
      this.id = id;
      this.titulo = titulo;
      this.centro = centro;
      this.fGrado = fGrado;
      this.pdf = pdf;
    }
  }
}
