using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics; //Para usar el BigInteger 
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_evaluacion
{
    internal class CalcularFactorial
    {
        // Función para calcular el factorial de un número
        public static BigInteger Factorial(int numero)
        {
            // Si el número es 0 o 1, el factorial siempre es 1
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            // Inicializamos la variable factorial con 1 para comenzar el cálculo
            BigInteger factorial = 1;

            // For que multiplica factorial por cada número desde 2 hasta el número dado
            for (int i = 2; i <= numero; i++)
            {
                factorial *= i;  // Multiplica el valor actual de factorial por i
            }

            // Devuelve el resultado final, que es el factorial del número
            return factorial;
        }

        // Función para mostrar los números y sus factoriales
        public static void MostrarResultados(int[] numeros, BigInteger[] factoriales, int cantidad)
        {
            Console.WriteLine("Número\tFactorial");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"{numeros[i]}\t{factoriales[i]}");
            }
        }

    }
}
