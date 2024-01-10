using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalUsuarioAdmin.Models
{
    public class ModeloVistaPersonalizado
    {
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public string sexo { get; set; }
        public string estado { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
        public string Provencia { get; set; }
        public string Departamento { get; set; }

    }
}