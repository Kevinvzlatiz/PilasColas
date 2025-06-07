using System;
using System.Collections.Generic;

namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {


            Queue<string> colas = new Queue<string>();
            //agregando elementos a la cola

            foreach (string cola in new string[5] { "A", "B", "C", "D", "E" })
            {

                colas.Enqueue(cola);

            }

            //recorriendo la cola

            System.Console.WriteLine("Recorriendo");

            foreach (string cola in colas)
            {

                System.Console.WriteLine(cola);

            }

            //eliminando elementos de la cola
            System.Console.WriteLine("Eliminando la cola");

            colas.Dequeue();
            
            foreach (string cola in colas)
            {

                System.Console.WriteLine(cola);

            }

        }
    }
}
 

