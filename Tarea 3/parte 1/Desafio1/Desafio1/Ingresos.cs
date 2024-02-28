using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    public class Ingresos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nombre: ");
            string nombreIngresado = Console.ReadLine();


            int numero1, numero2, numero3;

            Console.WriteLine("\ningrese el primer ingreso: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\ningrese el segundo ingreso: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\ningrese el tercer ingreso: ");
            numero3 = int.Parse(Console.ReadLine());

            double suma = Convert.ToDouble(numero1 + numero2 + numero3);
            double promedio = Convert.ToDouble(numero1 + numero2 + numero3) / 3;

            Console.Write("\nNombre: " + nombreIngresado + "\nSuma: " + suma + "\nPromedio: " + promedio);
            Console.ReadKey();
        }
    }
}