namespace CapaEntidad
{
  public class CursoD
  {
    public CursoD(int id, int idC, string nombre)
    {
      this.id = id;
      this.idC = idC;
      this.nombre = nombre;
    }

    public CursoD() { }
    public CursoD(string nombre) { this.nombre = nombre; }

    public int id { get; set; }
    public int idC { get; set; }
    public string nombre { get; set; }

  }
}
