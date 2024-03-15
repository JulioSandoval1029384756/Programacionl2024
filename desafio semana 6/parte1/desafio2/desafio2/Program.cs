using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
        {
            bool esPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            
            if (esPrimo && numero != 1)
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }
        }
        else
        {
            Console.WriteLine("Debe ingresar un número entero positivo.");
        }
    }
}
