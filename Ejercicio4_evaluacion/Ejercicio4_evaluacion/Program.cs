/*
 Crea un programa que use un arreglo estático para almacenar números y una función
que calcule el factorial de cada número, el cual es enviado a un segundo arreglo.
Muestra los resultados, es decir ambos arreglos
- El número es leído en la función principal Main y es enviado como parámetro a la
función que calcula el factorial. Recuerda que el factorial no se calcula para números
negativos. Por lo tanto, al arreglo original sólo debes guardar los números positivos
o cero.
- El programa se repetirá mientras el usuario lo desea.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_evaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE CALCULA EL FACTORIAL DE NÚMEROS POSITIVOS");
            const int tamaño = 100;  // Definimos el tamaño del arreglo
            int[] numeros = new int[tamaño];  // Arreglo para almacenar los números positivos o cero
            BigInteger[] factoriales = new BigInteger[tamaño];  // Ponemos el tipo a BigInteger para que pueda imprimir resultados grandes
            int indice = 0;  // Índice para controlar la posición en el arreglo
            string continuar;

            do
            {
                // Leer número ingresado por el usuario
                Console.Write("Ingrese un número positivo o cero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 0 && indice < tamaño)
                {
                    // Agregar el número al arreglo si es válido y hay espacio
                    numeros[indice] = numero;
                    factoriales[indice] = CalcularFactorial.Factorial(numero);  // Calcular el factorial y almacenarlo
                    indice++;  // Incrementar el índice
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Solo se permiten números positivos o cero.");
                }
                else
                {
                    Console.WriteLine("El arreglo está lleno. No puede ingresar más números.");
                    break;
                }

                // Preguntar si el usuario quiere continuar
                Console.Write("¿Desea ingresar otro número? (s/n): ");
                continuar = Console.ReadLine().ToLower();
            } while (continuar == "s" && indice < tamaño);

            // Mostrar los resultados
            CalcularFactorial.MostrarResultados(numeros, factoriales, indice);
            Console.ReadKey();
        }

    }

}
