using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    public class Profesor : Persona
    {
        private string noProfesor = "";
        private double sueldo;

        public string NoProfesor1 { get => noProfesor; set => noProfesor = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    }
}
