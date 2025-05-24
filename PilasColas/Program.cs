using Arreglos;
namespace PilasColas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pila = new Pilas(5);
            pila.Agregar("A");
            pila.Agregar("B");
        }
    }
}
