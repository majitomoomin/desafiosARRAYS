//desafio 3
using System;

using System.Collections.Generic;

class Program
{
    static List<string> tareas = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("App de tareas!");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");

            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        mostrartareas();
                        break;
                    case 2:
                        agregartarea();
                        break;
                    case 3:
                        eliminartarea();
                        break;
                    case 4:
                        Console.WriteLine("¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingresa un número válido.");
            }
        }
    }

    static void mostrartareas()
    {
        Console.WriteLine("\nTareas pendientes:");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    static void agregartarea()
    {
        Console.Write("Ingresa la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada correctamente.");
    }

    static void eliminartarea()
    {
        mostrartareas();
        Console.Write("Ingresa el número de la tarea que deseas eliminar: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tareas.Count)
        {
            tareas.RemoveAt(indice - 1);
            Console.WriteLine("Tarea eliminada correctamente.");
        }
        else
        {
            Console.WriteLine("Número de tarea no válido. Inténtalo de nuevo.");
        }
    }
}

