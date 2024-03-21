using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    class Program
    {
        static ArrayList tareas = new ArrayList();

        static void Main()
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("          Organizador de tareas           ");
                Console.WriteLine("1. Mostrar Tareas");
                Console.WriteLine("2. Agregar Tarea");
                Console.WriteLine("3. Eliminar Tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarTareas();
                        break;
                    case "2":
                        AgregarTarea();
                        break;
                    case "3":
                        EliminarTarea();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MostrarTareas()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas por mostrar.");
                return;
            }

            Console.WriteLine("Tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada correctamente.");
        }

        static void EliminarTarea()
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para eliminar.");
                return;
            }

            MostrarTareas();
            Console.Write("Ingrese el número de la tarea que desea eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tareas.Count)
            {
                tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Parametro incorrecto.");
            }
        }
    }
}
