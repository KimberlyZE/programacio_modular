/* Ejercicios de evaluación S9: Módulos y arreglos
 
Ejercicio 5: Escribe el programa que tenga una función que reciba un arreglo de enteros y lo
invierta (el primer elemento se convierte en el último, el segundo en el penúltimo,
etc.). Muestra el arreglo original y el invertido.

 Creado por: Arelys Castillo y Kimberly Zapata*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_evaluacion_S9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable para almacenar la cantidad de elementos en el arreglo
            int n;
            Console.Write("Ingrese la cantidad de elementos en el arreglo: ");
            n = int.Parse(Console.ReadLine());

            // Crea un arreglo de enteros con la longitud especificada por el usuario
            int[] numeros = new int[n];

            // Ciclo para llenar el arreglo con los elementos ingresados por el usuario
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Llama al método imprimirArreglo para mostrar el arreglo en orden original
            funcionesYmetodos.imprimirArreglo(numeros);
            Console.WriteLine();

            // Llama al método imprimirArregloInvertido para mostrar el arreglo en orden invertido
            funcionesYmetodos.imprimirArregloInvertido(numeros);
            Console.ReadKey();
        }
    }
}
