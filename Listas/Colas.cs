using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private List<string> _cola;

        public Colas()
        {
            _cola = new List<string>();
        }

        public void Agregar(string dato)
        {
            _cola.Add(dato);
        }

        private bool EstaVacio()
        {
            return (_cola.Count == 0);
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("La Lista esta vacía");
            }

            _cola.RemoveAt(0);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (EstaVacio())
            {
                return "Lista vacía";
            }

            int listaCount = _cola.Count;
            for (int i = 0; i < listaCount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }

                datos += _cola[i];
            }

            return datos;
        }

    }
}
