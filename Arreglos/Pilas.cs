namespace Arreglos
{
    public class Pilas
    {
        private string[] _arreglo;
        private int _tope;
        private int _max;

        public Pilas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
            _max = _arreglo.Length -1;
        }

        public void Agregar(string dato) 
        { 
            _arreglo[_tope] = dato;
            _tope++;
        }
    }
}
