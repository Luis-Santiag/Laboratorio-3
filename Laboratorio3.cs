using System;
using System.Collections.Generic;

class Program
{
    static List<string> estudiantes = new List<string>();
    static List<double> calificaciones = new List<double>();

    static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de calificaciones");
            Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    AgregarEstudiante();
                    break;
                case 2:
                    MostrarEstudiantes();
                    break;
                case 3:
                    CalcularPromedio();
                    break;
                case 4:
                    MostrarEstudianteConMaxCalificacion();
                    break;
                case 5:
                    salir = true;
                    Console.WriteLine("Saliendo del Programa");
                    break;
            }
            Console.WriteLine();
        }
    }
    static void AgregarEstudiante()
    {
        string nombre;
        double calificacion;

        Console.Write("Ingrese el nombre del estudiante: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese la calificación del estudiante: ");
        while (!double.TryParse(Console.ReadLine(), out calificacion))
        {
            Console.WriteLine("Entrada no valida Ingrese un numero.");
            Console.Write("Ingrese la calificación del estudiante: ");
        }
        estudiantes.Add(nombre);
        calificaciones.Add(calificacion);
        Console.WriteLine("Estudiante agregado correctamente.");
    }
    static void MostrarEstudiantes()
    {
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }
        else
        {
            Console.WriteLine("\nLista de estudiantes:");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
            }
        }
    }
    static void CalcularPromedio()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Count;
            Console.WriteLine($"El promedio de calificaciones es: {promedio}");
        }
    }
    static void MostrarEstudianteConMaxCalificacion()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double maxCalificacion = calificaciones[0];
            string estudianteMax = estudiantes[0];
            for (int i = 1; i < calificaciones.Count; i++)
            {
                if (calificaciones[i] > maxCalificacion)
                {
                    maxCalificacion = calificaciones[i];
                    estudianteMax = estudiantes[i];
                }
            }
            Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
        }
    }
}