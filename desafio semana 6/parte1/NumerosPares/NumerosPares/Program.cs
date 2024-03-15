using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
        {
            for (int i = 2; i <= numero; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Debe ingresar un número entero positivo.");
        }
    }
}
