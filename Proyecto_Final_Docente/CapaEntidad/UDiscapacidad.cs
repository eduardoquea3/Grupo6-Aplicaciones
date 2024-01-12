namespace CapaEntidad
{
  public class UDiscapacidad
  {
    public int id { get; set; }
    public int idDiscapacidad { get; set; }
    public string discapacidad { get; set; }
    public string descDiscapacidad { get; set; }

    public UDiscapacidad(
        int id,
        int idDiscapacidad,
        string discapacidad,
        string descDiscapacidad
    )
    {
      this.id = id;
      this.idDiscapacidad = idDiscapacidad;
      this.discapacidad = discapacidad;
      this.descDiscapacidad = descDiscapacidad;
    }
    public UDiscapacidad(
       int id,
       string discapacidad,
       string descDiscapacidad
   )
    {
      this.id = id;
      this.discapacidad = discapacidad;
      this.descDiscapacidad = descDiscapacidad;
    }
    public UDiscapacidad(
        string discapacidad,
        string descDiscapacidad
    )
    {
      this.discapacidad = discapacidad;
      this.descDiscapacidad = descDiscapacidad;
    }

    public UDiscapacidad() { }
  }
}
