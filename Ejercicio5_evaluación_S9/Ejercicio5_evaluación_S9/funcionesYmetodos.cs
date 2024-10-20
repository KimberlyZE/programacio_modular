
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_evaluacion_S9
{
    internal class funcionesYmetodos
    {
        // Método: imprimir un arreglo original
        public static void imprimirArreglo(int[] arreglo)
        {
            Console.Write("\nOriginal: ");

            // Recorre cada número en el arreglo y lo imprime en la consola
            foreach (int numero in arreglo)
            {
                Console.Write(numero + " ");
            }
        }

        // Método: imprimir un arreglo invertido
        public static void imprimirArregloInvertido(int[] arreglo)
        {
            // Variable auxiliar para el intercambio de elementos
            int auxiliar;

            // Intercambia los elementos del arreglo para invertirlo
            for (int i = 0; i < arreglo.Length / 2; i++)
            {
                auxiliar = arreglo[i]; // Guarda el valor del elemento actual en la variable auxiliar
                arreglo[i] = arreglo[arreglo.Length - 1 - i]; // Asigna el elemento opuesto a la posición actual
                arreglo[arreglo.Length - 1 - i] = auxiliar; // Asigna el valor almacenado en auxiliar a la posición opuesta
            }

            // Recorre el arreglo invertido y lo imprime en la consola
            Console.Write("Inverso: ");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
        }
    }
}
