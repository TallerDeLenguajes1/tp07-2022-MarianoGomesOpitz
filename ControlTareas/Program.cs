// See https://aka.ms/new-console-template for more information
using System;
namespace ControlTareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int cantTareas = rand.Next(2, 10);
            Console.WriteLine($"Tareas en total: {cantTareas}");
            var tareasPendientes = new List<Tarea>();
            var tareasRealizadas = new List<Tarea>();
            int id, dura, i;
            string desc;
            for (i = 0; i < cantTareas; i++)
            {
                Console.WriteLine($"\nTarea {i + 1}");

                Console.WriteLine("Ingrese la descripción de la tarea:");
                desc = Console.ReadLine();

                id = i + 1;

                dura = rand.Next(10, 100);

                var tarea = new Tarea(id, dura, desc);

                tareasPendientes.Add(tarea);
            }

            char reali;
            Console.WriteLine("\n\n/----------Listado de tareas pendientes----------/");
            for (i = tareasPendientes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"Id de la tarea: {tareasPendientes[i].TareaID}");
                Console.WriteLine($"Descripcion de la tarea: {tareasPendientes[i].Descripcion}");
                Console.WriteLine($"Duración de la tarea: {tareasPendientes[i].Duracion} minutos");

                Console.WriteLine("¿Esta tarea ha sido realizada? (\"Y\" para Sí):");
                reali = Console.ReadKey().KeyChar;
                if (reali == 'y' || reali == 'Y')
                {
                    Console.WriteLine("\nMoviendo a tareas realizadas...");
                    tareasRealizadas.Add(tareasPendientes[i]);
                    tareasPendientes.RemoveAt(i);
                }
            }
            Console.WriteLine("\n\n/----------Listado de tareas que quedaron pendientes----------/");
            foreach (var tareaPen in tareasPendientes)
            {
                Console.WriteLine($"\nId de la tarea: {tareaPen.TareaID}");
                Console.WriteLine($"Descripcion de la tarea: {tareaPen.Descripcion}");
                Console.WriteLine($"Duración de la tarea: {tareaPen.Duracion} minutos");
            }
            Console.WriteLine("\n\n/----------Listado de tareas realizadas----------/");
            foreach (var tareaRea in tareasRealizadas)
            {
                Console.WriteLine($"\nId de la tarea: {tareaRea.TareaID}");
                Console.WriteLine($"Descripcion de la tarea: {tareaRea.Descripcion}");
                Console.WriteLine($"Duración de la tarea: {tareaRea.Duracion} minutos");
            }
        }
    }
}