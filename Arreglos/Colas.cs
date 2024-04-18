using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Colas
    {
        private string[] _arreglo;
        private int _tope;
        private int _max;
        private int _inicio;

        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
            _inicio = 0;
            _max = _arreglo.Length - 1;
        }

        private bool EstaVacio()
        {
            return ((_inicio < 1 && _tope < 1) || _inicio == _tope);
        }

        private bool EstaLleno()
        {
            return (_tope > _max);
        }

        public void Agregar(string dato)
        {
            if (EstaLleno())
            {
                throw new Exception("No hay espacio");
            }
            _arreglo[_tope] = dato;
            _tope++;
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("Ya no hay elementos para eliminar");
            }
            _arreglo[_inicio] = null;
            _inicio++;
        }

        public string[] ObtenerArreglo()
        {
            return _arreglo;
        }
    }
}