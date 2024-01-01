namespace CapaEntidad
{
  public class ECurso
  {
    public int id { get; set; }
    public string nombre { get; set; }

    public ECurso(int id, string nombre)
    {
      this.id = id;
      this.nombre = nombre;
    }

    public ECurso() { }
  }
}
