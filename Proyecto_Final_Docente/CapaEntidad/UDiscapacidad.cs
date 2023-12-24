namespace CapaEntidad
{
  public class UDiscapacidad
  {
    public int id { get; set; }
    public string idDiscapacidad { get; set; }
    public string discapacidad { get; set; }
    public string descDiscapacidad { get; set; }

    public UDiscapacidad(
        int id,
        string idDiscapacidad,
        string discapacidad,
        string descDiscapacidad
    )
    {
      this.id = id;
      this.idDiscapacidad = idDiscapacidad;
      this.discapacidad = discapacidad;
      this.descDiscapacidad = descDiscapacidad;
    }

    public UDiscapacidad() { }
  }
}
