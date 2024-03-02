using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            int num1, num2, resSuma, resResta, resMulti, resDivi;
            Console.WriteLine("Ingresa el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resSuma = num1 + num2;
            resResta = num1 - num2;
            resMulti = num1 * num2;
            resDivi = num1 / num2;

            Console.WriteLine("\nSumma: " + resSuma + "\nResta: " + resResta + "\nMultiplicacion: " + resMulti + "\nDivicion: " + resDivi);
        }
    }
}
