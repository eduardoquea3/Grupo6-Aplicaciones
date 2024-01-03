using System.Globalization;
using System.Net;
using System.Net.Mail;

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
    public void mesagePass(string pass, string correo)
    {
      string body = $"<body><p>Buenas aqui le dejamos su contraseña <strong>{pass}</strong>.<br/> Le recomendamos que ni bien le llegue este mensaje cambie su contraseña</p></body>";

      MailMessage ms = new MailMessage();
      SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

      ms.From = new MailAddress("quesadarodrigo228@gmail.com");
      ms.To.Add(new MailAddress($"{correo}"));

      ms.Subject = "Recuperar contraseña";
      ms.IsBodyHtml = true;
      ms.Body = body;


      smtp.Credentials = new NetworkCredential("quesadarodrigo228@gmail.com", "sggjfwzgpforauaq");
      smtp.EnableSsl = true;
      smtp.Send(ms);
    }
    public void mesageReg(string correo)
    {
      string body = $"<body><p>Buenas que su registro fue exitoso</p></body>";

      MailMessage ms = new MailMessage();
      SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

      ms.From = new MailAddress("quesadarodrigo228@gmail.com");
      ms.To.Add(new MailAddress($"{correo}"));

      ms.Subject = "Registro exitoso";
      ms.IsBodyHtml = true;
      ms.Body = body;


      smtp.Credentials = new NetworkCredential("quesadarodrigo228@gmail.com", "sggjfwzgpforauaq");
      smtp.EnableSsl = true;
      smtp.Send(ms);
    }
    public void mesage(string correo)
    {
      string body = $"<body><p>Buenas le avisamos que hubo cambio de contraseña en su cuenta</p></body>";

      MailMessage ms = new MailMessage();
      SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

      ms.From = new MailAddress("quesadarodrigo228@gmail.com");
      ms.To.Add(new MailAddress($"{correo}"));

      ms.Subject = "Cambio contraseña";
      ms.IsBodyHtml = true;
      ms.Body = body;


      smtp.Credentials = new NetworkCredential("quesadarodrigo228@gmail.com", "sggjfwzgpforauaq");
      smtp.EnableSsl = true;
      smtp.Send(ms);
    }
  }
}
