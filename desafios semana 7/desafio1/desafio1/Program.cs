using System;
using System.Collections.Generic;
using System;

namespace desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[3, 3] { { "x", "o", "o" }, { "o", "x", "x" }, { "o", "o", "x" } };

          
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nGanador jugador 'X'");
        }
    }
}