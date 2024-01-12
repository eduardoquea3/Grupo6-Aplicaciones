namespace CapaEntidad
{
  public class URegistro : Usuario
  {
    public int id { get; set; }
    public string sexo { get; set; }
    public int tipoSexo { get; set; }
    public string civil { get; set; }
    public int tipoCivil { get; set; }
    public string direccion { get; set; }
    public string ubigeo { get; set; }
    public string dpto { get; set; }
    public string prov { get; set; }
    public string dist { get; set; }
    public string telefono { get; set; }
    public string celular { get; set; }
    public string foto { get; set; }
    public string fNac { get; set; }
    public double precio { get; set; }

    public URegistro(
        string sexo,
        string civil,
        string direccion,
        string ubigeo,
        string dpto,
        string prov,
        string dist,
        string telefono,
        string celular,
        string foto,
        string fNac,
        double precio
    )
    {
      this.sexo = sexo;
      this.civil = civil;
      this.direccion = direccion;
      this.ubigeo = ubigeo;
      this.dpto = dpto;
      this.prov = prov;
      this.dist = dist;
      this.telefono = telefono;
      this.celular = celular;
      this.foto = foto;
      this.fNac = fNac;
      this.precio = precio;
    }
    public URegistro(
        int tipoSexo,
        int tipoCivil,
        string direccion,
        string ubigeo,
        string dpto,
        string prov,
        string dist,
        string telefono,
        string celular,
        string foto,
        string fNac,
        double precio
    )
    {
      this.tipoSexo = tipoSexo;
      this.tipoCivil = tipoCivil;
      this.direccion = direccion;
      this.ubigeo = ubigeo;
      this.dpto = dpto;
      this.prov = prov;
      this.dist = dist;
      this.telefono = telefono;
      this.celular = celular;
      this.foto = foto;
      this.fNac = fNac;
      this.precio = precio;
    }
    public URegistro(
        int id,
        int tipoSexo,
        int tipoCivil,
        string direccion,
        string ubigeo,
        string telefono,
        string celular,
        string foto,
        string fNac,
        double precio
    )
    {
      this.id = id;
      this.tipoSexo = tipoSexo;
      this.tipoCivil = tipoCivil;
      this.direccion = direccion;
      this.ubigeo = ubigeo;
      this.telefono = telefono;
      this.celular = celular;
      this.foto = foto;
      this.fNac = fNac;
      this.precio = precio;
    }

    public URegistro() { }
  }
}
