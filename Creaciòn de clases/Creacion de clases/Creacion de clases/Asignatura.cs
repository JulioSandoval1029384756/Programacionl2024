using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    public class Asignatura
    {
        private string nombre_de_asignatura = "";
        private string descripcion = "";

        public string Nombre_de_asignatura { get => nombre_de_asignatura; set => nombre_de_asignatura = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
