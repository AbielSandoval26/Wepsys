using System;
using System.Collections.Generic;
using System.Linq;

namespace Wepsys
{
    class Program
    {
        static void PosiblesAmigos()
        {
            string Nombre = "Abiel";
            //string[] Amigos = new string[] { "Juan", "Javier", "Juana", "Marcos" };

            List<string> amigos = new List<string>()
                { "Juan", "Javier", "Juana", "Marcos" };

            char delimitador = ',';

            string[] PA = amigos.split

            /*IEnumerable<string> enumerable()
            {
                return from string amigo in amigos
                       where amigo.Length == Nombre.Length
                       select amigo;
                
            };*/

            Console.WriteLine();

            /*foreach (var amigo in amigos)
            {
                if (amigo == 5)
                {
                    Console.WriteLine(amigo);
                };
            }*/



        }

        static void Main(string[] args)
        {
            PosiblesAmigos();
            Console.ReadKey();
            
            
        }

        

    }
}
