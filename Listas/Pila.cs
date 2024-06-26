﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> _lista;
        
        public Pilas()
        {
            _lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }

        private bool EstaVacio()
        {
            return (_lista.Count == 0);
        }

        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("La Lista esta vacía");
            }

            _lista.RemoveAt(_lista.Count - 1);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (EstaVacio())
            {
                return "Lista vacía";
            }

            int listaCount = _lista.Count;
            for (int i = 0; i < listaCount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }

                datos += _lista[i];
            }

            return datos;
        }

    }
    }
  