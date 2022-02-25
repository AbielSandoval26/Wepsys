using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;

            x1 = 3;
            x2 = 4;
            y1 = 2; 
            y2 = 5;

            var distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            var suma = Math.Sqrt((Math.Pow(x1 + x2,2) + Math.Pow(y1+y2,2)));
            var multiplicacion = Math.Sqrt((Math.Pow(x1 * x2, 2) + Math.Pow(y1 * y2, 2)));

            Console.WriteLine(distancia);
            Console.WriteLine(suma);
            Console.WriteLine(multiplicacion);





            Console.ReadKey();
        }
    }
}
