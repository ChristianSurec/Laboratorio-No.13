using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_No._13
{
    public class Personal : Persona
    {
        public string noIgss { get; set; }
        public string profesion { get; set; }
        public DateTime fechaInicioLabor { get; set; }
        public DateTime fechaFinLabor { get; set; }
    }
}