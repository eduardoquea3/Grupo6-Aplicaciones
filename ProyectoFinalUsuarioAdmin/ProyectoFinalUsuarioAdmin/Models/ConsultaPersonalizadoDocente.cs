using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalUsuarioAdmin.Models
{
    public class ConsultaPersonalizadoDocente
    {
        public string NombreCompleto { get; set; }
        public string Username { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public string sexo { get; set; }
        public string EstadoCivil{ get; set; }
        public string Direccion { get; set; }
        public string distrito { get; set; }
        public string Provencia { get; set; }
        public string Departamento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Foto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string PrecioXHora {  get; set; }

    }
}