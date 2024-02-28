using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> usuarios = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Bienvenido al sistema de inicio de sesión de usuario.");
            Console.WriteLine("1. Registrarse");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarUsuario();
                    break;
                case "2":
                    IniciarSesion();
                    break;
                case "3":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void RegistrarUsuario()
    {
        Console.WriteLine("Por favor, introduzca un nombre de usuario:");
        string nombreUsuario = Console.ReadLine();

        if (usuarios.ContainsKey(nombreUsuario))
        {
            Console.WriteLine("El nombre de usuario ya existe. Por favor, elija otro nombre de usuario.");
            return;
        }

        Console.WriteLine("Por favor, introduzca una contraseña:");
        string contraseña = Console.ReadLine();

        usuarios.Add(nombreUsuario, contraseña);

        Console.WriteLine("Usuario registrado exitosamente.");
    }

    static void IniciarSesion()
    {
        Console.WriteLine("Por favor, introduzca su nombre de usuario:");
        string nombreUsuario = Console.ReadLine();

        if (!usuarios.ContainsKey(nombreUsuario))
        {
            Console.WriteLine("Nombre de usuario no encontrado. Por favor, regístrese primero.");
            return;
        }

        Console.WriteLine("Por favor, introduzca su contraseña:");
        string contraseña = Console.ReadLine();

        if (usuarios[nombreUsuario] == contraseña)
        {
            Console.WriteLine("Inicio de sesión exitoso. ¡Bienvenido!");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Por favor, inténtelo de nuevo.");
        }
    }
}