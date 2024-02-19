using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    public class Curso
    {
        private string nombre_del_curso = "";
        private string docente_acargo = "";
        private string horario = "";
        private string aula_asignada = "";

        public string Nombre_del_curso { get => nombre_del_curso; set => nombre_del_curso = value; }
        public string Docente_acargo { get => docente_acargo; set => docente_acargo = value; }
        public string Horario { get => horario; set => horario = value; }
        public string Aula_asignada { get => aula_asignada; set => aula_asignada = value; }
    }
}
