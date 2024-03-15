using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las calificaciones. Cuando termine, escriba 'fin'.");

        int suma = 0;
        int cantidadCalificaciones = 0;
        string entrada;

        do
        {
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "fin")
            {
                if (cantidadCalificaciones == 0)
                {
                    Console.WriteLine("No se ingresaron calificaciones.");
                }
                else
                {
                    double promedio = (double)suma / cantidadCalificaciones;
                    Console.WriteLine($"El puntaje promedio del estudiante es: {promedio:F2}");
                }
            }
            else if (int.TryParse(entrada, out int calificacion))
            {
                if (calificacion >= 1 && calificacion <= 10)
                {
                    suma += calificacion;
                    cantidadCalificaciones++;
                }
                else
                {
                    Console.WriteLine("El puntaje debe estar entre 1 y 10.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido o 'fin' para finalizar.");
            }
        } while (entrada.ToLower() != "fin");
    }
}
