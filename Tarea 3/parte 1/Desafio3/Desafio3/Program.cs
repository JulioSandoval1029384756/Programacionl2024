using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int resultado = SumarDosValores();
            Console.WriteLine($"La suma de los dos valores es: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operación completada.");
        }
    }

    public static int SumarDosValores()
    {
        int valor1 = 0;
        int valor2 = 0;

        Console.WriteLine("Ingrese el primer valor:");
        string input1 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input1))
        {
            throw new ArgumentException("El valor ingresado no puede estar en blanco.");
        }

        Console.WriteLine("Ingrese el segundo valor:");
        string input2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input2))
        {
            throw new ArgumentException("El valor ingresado no puede estar en blanco.");
        }

        try
        {
            valor1 = Convert.ToInt32(input1);
            valor2 = Convert.ToInt32(input2);
            return valor1 + valor2;
        }
        catch (FormatException)
        {
            throw new ArgumentException("Los valores ingresados deben ser números enteros.");
        }
    }
}