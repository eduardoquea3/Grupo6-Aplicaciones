namespace CapaEntidad
{
  public class ECivil
  {
    public int id { get; set; }
    public string tipo { get; set; }
    public ECivil() { }
    public ECivil(int id, string tipo)
    {
      this.id = id;
      this.tipo = tipo;
    }
  }
}
