namespace CapaEntidad
{
  public class ESexo
  {
    public int id { get; set; }
    public string tipo { get; set; }
    public ESexo() { }
    public ESexo(int id, string tipo)
    {
      this.id = id;
      this.tipo = tipo;
    }
  }
}
