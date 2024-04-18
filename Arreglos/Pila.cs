using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pila
    {
        private string[] _arreglo;
        private int _tope;
        private int _max;

        public Pila(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
            _max = _arreglo.Length - 1;
        }

        private bool EstaLleno()
        {
            if (_tope > _max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Agregar(string dato)
        {
            if (EstaLleno() == true)
            {
                throw new Exception("No hay espacio");
            }
            _arreglo[_tope] = dato;
            _tope++;
        }

        private bool EstaVacio()
        {
            if (_tope < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Eliminar()
        {
            if (EstaVacio() == true)
            {
                throw new Exception("Ya no hay elementos para eliminar");
            }
            _tope--;
            _arreglo[_tope] = string.Empty;
        }

        public string[] ObtenerArreglo()
        {
            return _arreglo;
        }
    }
}