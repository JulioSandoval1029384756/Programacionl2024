using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    public class Aula
    {
        private string Número_de_aula = "";
        private int Capacidad;
        private string Ubicación = "";
        private string Equipamiento = "";

        public string Número_de_aula1 { get => Número_de_aula; set => Número_de_aula = value; }
        public int Capacidad1 { get => Capacidad; set => Capacidad = value; }
        public string Ubicación1 { get => Ubicación; set => Ubicación = value; }
        public string Equipamiento1 { get => Equipamiento; set => Equipamiento = value; }
    }
}
