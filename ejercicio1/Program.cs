using System;
using System.Collections.Generic;
using System.Linq;

namespace Wepsys
{
    class Program
    {
        static void PosiblesAmigos()
        {
            //NOTA: ESTE CODIGO FUE EL REALIZADO DURANTE LA PRUEBA EN VIVO!!!
            
            string Nombre = "Abiel";
            //string[] Amigos = new string[] { "Juan", "Javier", "Juana", "Marcos" };

            List<string> amigos = new List<string>()
                { "Juan", "Javier", "Juana", "Marcos" };

            /* Esto no es utilizado pero aun asi lo dejo para que quede como demostrable
            de que no realice ningun cambio bruzcamente.*/
            
            char delimitador = ',';  
            string[] PA = amigos.split 

            /*IEnumerable<string> enumerable()
            {
                return from string amigo in amigos
                       where amigo.Length == Nombre.Length
                       select amigo;
                
            };*/
                
            //NOTA: ESTE foreach fue agregado despues

            foreach (string amigo in amigos)
            {
                if (amigo.Length == Nombre.Length) 
                {
                    Console.WriteLine("Tu posible amigo es " + amigo);
                }
                
            }

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
