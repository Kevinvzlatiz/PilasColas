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
            _max = _arreglo.Length - 1;
        }

        public void Agregar(string dato)
        {
            if (_tope > _max)
            {
                throw new Exception("El arreglo está lleno");
            }

            _arreglo[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (_tope < 1)
            {
                throw new Exception("No hay nada que eliminar");
            }

            _tope--;
            _arreglo[_tope] = "";

        }

        public string Imprimir()
        {
            string datos = string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                datos += _arreglo[i];
            }
            return datos;
        }
    }
}
