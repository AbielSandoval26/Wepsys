using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTA: ESTE CODIGO FUE EL REALIZADO DURANTE LA PRUEBA EN VIVO!!!
            // ESTE CODIGO POSEE EL CODIGO ORIGINAL COMO EL MODIFICADO, POR ESO SE OBSERVA QUE HAY 2 CICLOS FOR
            
            string Oracion = "Maria lava la ropa";

            char delimitador = ' ';
            string[] valores = Oracion.Split(delimitador);

            /* Este for esta mal estructurado debido a que lanza el orden de atras para alante
               es decir (ropa 4, la 2, lava 4, Maria 5) */
            
            for (int y = valores.GetLength(0) -1; y>=0; y-- )
            {
                Console.WriteLine(valores[y] + " " + valores[y].Length);

            }
            
            /* En cambio es solucionado de la siguiente manera: */
            
            for (int i= 0; i < valores.Length; i++ )
            {
                Console.WriteLine(valores[i] + " " + valores[i].Length);

            }
           
            
            Console.ReadKey();
        }
    }
}
