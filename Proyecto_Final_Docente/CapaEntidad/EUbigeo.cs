namespace CapaEntidad
{
  public class EUbigeo
  {
    public EUbigeo(int id, string dpto, string prov, string dist)
    {
      this.id = id;
      this.dpto = dpto;
      this.prov = prov;
      this.dist = dist;
    }
    public EUbigeo(string dpto, string prov, string dist)
    {
      this.dpto = dpto;
      this.prov = prov;
      this.dist = dist;
    }
    public EUbigeo() { }
    public EUbigeo(string data) { this.data = data; }
    public EUbigeo(string dpto, string prov)
    {
      this.dpto = dpto;
      this.prov = prov;
    }

    public int id { get; set; }
    public string dpto { get; set; }
    public string prov { get; set; }
    public string dist { get; set; }
    public string data { get; set; }
  }
}
