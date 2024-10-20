/*
Crea un programa que solicite al usuario la base y la altura de
un triángulo. El programa debe incluir una función llamada
calcular_area_triangulo que reciba como parámetros la base y
la altura, y devuelva el área del triángulo. La fórmula para
calcular el área es:
Área =(base * altura) /2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modular_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar la base del triángulo al usuario
            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangulo = double.Parse(Console.ReadLine());

            // Solicitar la altura del triángulo al usuario
            Console.WriteLine("Ingrese la altura del triángulo:");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            // Crear una instancia de la clase Triangulo para usar su método
            AreaTriangulo triangulo = new AreaTriangulo();

            // Llamar al método que calcula el área y guardar el resultado en la variable 'area'
            double area = triangulo.calcular_area_triangulo(baseTriangulo, alturaTriangulo);

            // Mostrar el área del triángulo en la consola
            Console.WriteLine($"El área del triángulo es: {area:F2}");

            Console.ReadKey();  
        }
    }
    
}
