using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    
    }
     class Program
    {
        static void Main()
        {
            int[,] compras = {
            {50, 10, 6, 15, 7},   
            {23, 134, 420, 150, 200},  
            {100, 90, 80, 70, 60},   
            {100, 236, 30, 189, 465},    
            {4398, 713, 409, 379, 500}   
        };

            AplicarDescuentos(compras);
        }

        static void AplicarDescuentos(int[,] compras)
        {
            
            for (int cliente = 0; cliente < compras.GetLength(0); cliente++)
            {
                int totalCompras = 0;

                for (int compra = 0; compra < compras.GetLength(1); compra++)
                {
                    totalCompras += compras[cliente, compra];
                }

                double descuento = 0;
                if (totalCompras >= 100 && totalCompras <= 1000)
                {
                    descuento = 0.1; 
                }
                else if (totalCompras > 1000)
                {
                    descuento = 0.2; 
                }

                double montoFinal = totalCompras - (totalCompras * descuento);

               
                Console.WriteLine($"\nCliente {cliente + 1}: compras = {totalCompras}, Descuento = {descuento * 100}%, Monto a pagar = {montoFinal}");
            }
        }
    }
