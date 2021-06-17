using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OM.WS.DATOSEMPLEADO.BE.Models
{
    public class Colaborador
    {
        public long IdColaborador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Edad { get; set; }
        public string Profesion { get; set; }
        public string EstadoCivil { get; set; }

    }
}