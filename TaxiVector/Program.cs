using System;
using System.Reflection;

namespace DeHaro.CabbieGeometry.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(7, 9);
            var p2 = new Point(2, 3);
            var MDist = new ManhattanDistance(p1, p2);

            var solucion = MDist.Calculate();

            Console.WriteLine($"la solución es: {solucion}");
        }
    }

   
}

