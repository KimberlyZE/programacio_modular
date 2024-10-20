using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modular_1
{
    internal class AreaTriangulo
    {
        // Método que recibe la base y la altura, y devuelve el área del triángulo
        public double calcular_area_triangulo(double baseTriangulo, double alturaTriangulo)
        {
            // La fórmula del área del triángulo: (base * altura) / 2
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
