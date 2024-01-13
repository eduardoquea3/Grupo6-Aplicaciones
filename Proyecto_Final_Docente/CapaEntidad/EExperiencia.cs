namespace CapaEntidad
{
  public class EExperiencia
  {
    public int idE { get; set; }
    public int id { get; set; }
    public string fInicio { get; set; }
    public string fFin { get; set; }
    public string cargo { get; set; }
    public string empresa { get; set; }
    public string certificado { get; set; }

    public EExperiencia() { }

    public EExperiencia(
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

    public EExperiencia(
        int id,
        int idE,
        string cargo,
        string empresa,
        string fInicio,
        string fFin,
        string certificado
    )
    {
      this.id = id;
      this.idE = idE;
      this.cargo = cargo;
      this.empresa = empresa;
      this.fInicio = fInicio;
      this.fFin = fFin;
      this.certificado = certificado;
    }
  }
}
