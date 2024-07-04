using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaLambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> suma = (a, b) => a + b;
            Console.WriteLine(suma(3, 4));

            Func<double, double> prod = x => x * x;
            Console.WriteLine(prod(10));

            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(10, "Programacion1"));

            Action<int> MayorEdad = n =>
            {
                Boolean ME = (n > 18) ? true : false;
                Console.WriteLine($"Es mayor de edad {ME}");
            };
            MayorEdad(15);

            Action<string> saludar = _ => Console.WriteLine("¡Hola!");
            saludar("Ignorado"); // Salida: ¡Hola!





            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("PARTE INDEPENDIENTE");


            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("Demitra", 21, 69.0),
                new Estudiante("Moises", 20, 77.0),
                new Estudiante("Cinthya", 19, 75.5),
                new Estudiante("Paola", 19, 81.8),
                new Estudiante("Julio", 17, 60.1)
            };

            var mayoresDe18 = estudiantes.Where(e => e.Edad > 18).ToList();
            Console.WriteLine("Mayores de 18 años:");
            mayoresDe18.ForEach(e => Console.WriteLine(e));

            var mejorEstudiante = estudiantes.OrderByDescending(e => e.Nota).FirstOrDefault();
            Console.WriteLine($"\nNota más alta:\n{mejorEstudiante}");

            var estudiantesOrdenados = estudiantes.OrderBy(e => e.Nombre).ToList();
            Console.WriteLine("\nOrdenados por nombre:");
            estudiantesOrdenados.ForEach(e => Console.WriteLine(e));

            var promedioNotas = estudiantes.Average(e => e.Nota);
            Console.WriteLine($"\nPromedio de notas: {promedioNotas}");
        }

    }

    
}
