using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    public class Persona
    {
        private string nombre = "";
        private string apellido = "";
        private string nacimiento = "";
        private int telefono;
        private string direccion = "";

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nacimiento { get => nacimiento; set => nacimiento = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public void crearPersona(string _nombre, string _apellido, string _nacimiento, int _telefono, string _direccion)
        {
            nombre = _nombre;
            apellido = _apellido;
            nacimiento = _nacimiento;
            telefono = _telefono;
            direccion = _direccion;

        }
    }
}
