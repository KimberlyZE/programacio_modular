/*Ejercicios de evaluación S9: Módulos y arreglos
 
Ejercicio 1: Programa que sea capaz de almacenar los datos de 10 personas: nombre, dirección,
teléfono, edad (usando structs). Deberá ir pidiendo los datos uno por uno, hasta que
el usuario lo decida. Entonces deberá aparecer un menú que permita

 Realizado por: Arelys Obando y Kimberly Zapata*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio1_evaluación_S9.FuncionesYmetodos;

namespace Ejercicio1_evaluación_S9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista para almacenar objetos de tipo Estudiante
            List<Estudiante> Estudiantes = new List<Estudiante>();
            int opcion;

            // Ciclo que se repite hasta que el usuario elige salir
            do
            {
                //menú principal
                Console.WriteLine("\nGestión de Estudiantes");
                Console.WriteLine("1. Añadir estudiante");
                Console.WriteLine("2. Mostrar todos los nombres");
                Console.WriteLine("3. Mostrar por edad");
                Console.WriteLine("4. Mostrar por nombre");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());
                // Se utiliza un switch para determinar qué acción realizar
                switch (opcion)
                {
                    case 1:
                        AgregarEstudiante(Estudiantes);
                        break;
                    case 2:
                        MostrarNombres(Estudiantes);
                        break;
                    case 3:
                        MostrarPorEdad(Estudiantes);
                        break;
                    case 4:
                        MostrarPorNombre(Estudiantes);
                        break;
                    case 5:
                        Console.WriteLine("\nSaliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
                // Limpia la consola para mostrar el menú nuevamente
                Console.Clear();
            } while (opcion != 5);
        }
    }
}
