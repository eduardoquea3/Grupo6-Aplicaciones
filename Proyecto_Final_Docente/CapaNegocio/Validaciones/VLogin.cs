using System.Globalization;

namespace CapaNegocio.Validaciones
{
  public class VLogin
  {
    public string Capitalize(string data)
    {
      TextInfo text = CultureInfo.CurrentCulture.TextInfo;
      return text.ToTitleCase(data);
    }
    public string PrimaryWord(string cadena)
    {
      int indiceEspacio = cadena.IndexOf(' ');

      if (indiceEspacio != -1)
      {
        return cadena.Substring(0, indiceEspacio);
      }
      else
      {
        return cadena;
      }
    }
  }
}
