namespace CapaEntidad
{
  public class ULogin : Usuario
  {
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellidoPat { get; set; }
    public string apellidoMat { get; set; }
    public string username { get; set; }
    public string tipo { get; set; }
    public int documento { get; set; }
    public string correo { get; set; }
    public string contra { get; set; }

    public ULogin(
        string nombre,
        string apellidoPat,
        string apellidoMat,
        string username,
        string tipo,
        int documento,
        string correo,
        string contra
    )
    {
      this.nombre = nombre;
      this.apellidoPat = apellidoPat;
      this.apellidoMat = apellidoMat;
      this.username = username;
      this.tipo = tipo;
      this.documento = documento;
      this.correo = correo;
      this.contra = contra;
    }

    public ULogin(string correo, string contra)
    {
      this.correo = correo;
      this.contra = contra;
    }

    public ULogin(int documento, string correo)
    {
      this.correo = correo;
      this.documento = documento;
    }

    public ULogin(int id)
    {
      this.id = id;
    }

    public ULogin() { }

    public ULogin(
        string nombre,
        string apeP,
        string apeM,
        string username,
        string tipo,
        int doc,
        string correo
    )
    {
      this.nombre = nombre;
      this.apellidoPat = apeP;
      this.apellidoMat = apeM;
      this.username = username;
      this.tipo = tipo;
      this.documento = doc;
      this.correo = correo;
    }
  }
}
