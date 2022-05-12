using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_No._13
{
    public class Puesto
    {
        public string puesto { get; set; }
        public List<Alumno> alumno { get; set; }
        public List<Profesor> profesor { get; set; }
        public List<Personal> personal { get; set; }

    }
}