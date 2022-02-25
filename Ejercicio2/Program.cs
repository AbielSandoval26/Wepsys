using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Oracion = "Maria lava la ropa";

            char delimitador = ' ';
            string[] valores = Oracion.Split(delimitador);

            for (int y = valores.GetLength(0) -1; y>=0; y-- )
            {
                Console.WriteLine(valores[y] + " " + valores[y].Length);

            }
            
            Console.ReadKey();
        }
    }
}
