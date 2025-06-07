using Arreglos;

namespace PilasColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pilas pila = new Pilas(5);
                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");
                pila.Agregar("D");
                pila.Agregar("E");
                //pila.Agregar("F");

                // string contenidoPila = pila.Imprimir();
                System.Console.WriteLine(pila.Imprimir());

                System.Console.WriteLine("Eliminando");
                pila.Eliminar();
                System.Console.WriteLine(pila.Imprimir());

                System.Console.WriteLine("Eliminando");
                pila.Eliminar();
                System.Console.WriteLine(pila.Imprimir());

                System.Console.WriteLine("Eliminando");
                pila.Eliminar();
                System.Console.WriteLine(pila.Imprimir());

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            
        }
    }
}
