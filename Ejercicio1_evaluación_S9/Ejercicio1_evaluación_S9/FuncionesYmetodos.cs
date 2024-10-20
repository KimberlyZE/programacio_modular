using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio1_evaluación_S9.FuncionesYmetodos;

namespace Ejercicio1_evaluación_S9
{
    internal class FuncionesYmetodos
    {
        // Definición de la clase Estudiante que representa la información de un estudiante
        public class Estudiante
        {
            //Propiedades para almacenar
            public string Nombre;
            public string Direccion;
            public int Telefono;
            public int Edad;

            //Constructor
            public Estudiante(string nombre, string direccion, int telefono, int edad)
            {
                Nombre = nombre;
                Direccion = direccion;
                Telefono = telefono;
                Edad = edad;
            }
        }

        //// Método para agregar un nuevo estudiante a la lista
        public static void AgregarEstudiante(List<Estudiante> Estudiantes)
        {
            // Verifica si ya se alcanzó el límite de 10 estudiantes
            if (Estudiantes.Count >= 10)
            {
                Console.WriteLine("\nSe ha alcanzado el límite de registros.");
                return;
            }

            // Solicita los datos del nuevo estudiante
            Console.WriteLine("\nRegistrar Estudiantes");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Teléfono: ");
            int telefono = int.Parse(Console.ReadLine());
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            // Crea un nuevo objeto Estudiante con los datos ingresados
            Estudiante nuevaPersona = new Estudiante(nombre, direccion, telefono, edad);
            // Agrega el nuevo estudiante a la lista
            Estudiantes.Add(nuevaPersona);
            Console.WriteLine("\nEstudiante añadido exitosamente.");
        }

        // Método para mostrar todos los nombres de los estudiantes
        public static void MostrarNombres(List<Estudiante> Estudiantes)
        {
            Console.WriteLine("\nLista de Estudiantes:");
            // Recorre la lista de estudiantes e imprime cada nombre
            foreach (var Estudiante in Estudiantes)
            {
                Console.WriteLine(Estudiante.Nombre);
            }
        }

        // Método para mostrar estudiantes filtrados por edad
        public static void MostrarPorEdad(List<Estudiante> Estudiantes)
        {
            Console.Write("\nIngrese la edad que desea buscar: ");
            int edadBuscada = int.Parse(Console.ReadLine());
            Console.WriteLine("Personas de {0} años:", edadBuscada);

            // Recorre la lista de estudiantes y muestra los que coinciden con la edad buscada
            foreach (var Estudiante in Estudiantes)
            {
                if (Estudiante.Edad == edadBuscada)
                {
                    Console.WriteLine(Estudiante.Nombre);
                }
            }
        }

        // Método para mostrar estudiantes filtrados por nombre
        public static void MostrarPorNombre(List<Estudiante> Estudiantes)
        {
            Console.Write("\nIngrese el nombre que desea buscar: ");
            string nombreBuscado = Console.ReadLine();
            Console.WriteLine("\nPersonas con el nombre {0}:", nombreBuscado);

            // Recorre la lista de estudiantes y muestra los que coinciden con el nombre buscado
            foreach (var Estudiante in Estudiantes)
            {
                // Comparación de nombres ignorando mayúsculas y minúsculas
                if (Estudiante.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    //Imprimir
                    Console.WriteLine("{0}", Estudiante.Nombre);
                    Console.WriteLine("{0}", Estudiante.Direccion);
                    Console.WriteLine("{0}", Estudiante.Telefono);
                    Console.WriteLine("{0}\n", Estudiante.Edad);
                }
            }
        }
    }
}