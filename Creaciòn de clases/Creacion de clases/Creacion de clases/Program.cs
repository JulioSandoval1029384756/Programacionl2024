using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante objEst = new Estudiante();
            objEst.Nombre = "Juan Jose";
            objEst.Apellido = "Martinez";
            objEst.Nacimiento = "19/5/2005";
            objEst.Telefono = 67294920;
            objEst.Direccion = "Zona 8";
            objEst.Carnet = 050619;
            objEst.Fecha_de_ingreso = "19/2/2024";
            objEst.Grado = "Tercer ciclo";

            Console.WriteLine("Estudiante \nNombre: " + objEst.Nombre + "\nApellido: " + objEst.Apellido + "\nNacimiento: " + objEst.Nacimiento + "\nTelefono: " + objEst.Telefono + "\nDireccion: " + objEst.Direccion + "\nCarnet: " + objEst.Carnet + "\nFecha de ingreso: " + objEst.Fecha_de_ingreso + "\nGrado: " + objEst.Grado);

            Profesor objPro = new Profesor();
            objPro.crearPersona("Jose", "Perez", "10/7/1982", 28452920, "502-zona1" );
            objPro.NoProfesor1 = "0709";
            objPro.Sueldo = 4500;

            Console.WriteLine("\nProfesor \nNombre: " + objPro.Nombre + "\nApellido: " + objPro.Apellido + "\nNacimiento: " + objPro.Nacimiento + "\nTelefono: " + objPro.Telefono + "\nDireccion: " + objPro.Direccion + "\nNo. Profesor: " + objPro.NoProfesor1 + "\nSueldo: " + objPro.Sueldo);
        }      
    }
}
