using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    public class Estudiante : Persona
    {
        private int carnet;
        private string fecha_de_ingreso = "";
        private string grado = "";

        public int Carnet { get => carnet; set => carnet = value; }
        public string Fecha_de_ingreso { get => fecha_de_ingreso; set => fecha_de_ingreso = value; }
        public string Grado { get => grado; set => grado = value; }
    }
}
