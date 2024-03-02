using System;

namespace Serie_2
{
    public class Operaciones
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros que desea: ");
            int CantidadDeNumeros = int.Parse(Console.ReadLine());

            int[] numeros = new int[CantidadDeNumeros];
            int NumerosPares = 0;
            int NumerosImpares = 0;
            int SumaPares = 0;
            int SumaImpares = 0;

            for (int i = 0; i < CantidadDeNumeros; i++)
            {
                Console.Write($"Ingrese el numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());

                if (numeros[i] % 2 == 0)
                {
                    NumerosPares++;
                    SumaPares += numeros[i];
                }
                else
                {
                    NumerosImpares++;
                    SumaImpares += numeros[i];
                }
            }

            Console.WriteLine("\nCantidad numeros pares: " + NumerosPares + " \nSuma numeros pares: " + SumaPares + " \nCantidad numeros impares: " + NumerosImpares + " \nSuma impares: " + SumaImpares);
        }
    }
}
