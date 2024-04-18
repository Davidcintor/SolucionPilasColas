using Arreglos;
using Listas;
using System;

namespace PilasColas
{
    class Program
    {
        public static void Main(string[] args)
        { 
            ArregloPila();
            ArregloColas();
        }


            static void ArregloPila()
            {
                Arreglos.Pila pila = new Arreglos.Pila(5);

                void Imprimir(string[] elementos)
                {
                    //Console.Clear();
                    Console.WriteLine();
                    foreach (string elemento in elementos)
                    {
                        Console.WriteLine(elemento);
                    }
                }
                try
                {

                    pila.Agregar("Pepe0");
                    pila.Agregar("Pepe1");
                    pila.Agregar("Pepe2");
                    pila.Agregar("Pepe3");
                    pila.Agregar("Pepe4");

                    Imprimir(pila.ObtenerArreglo());

                    pila.Eliminar();
                    Imprimir(pila.ObtenerArreglo());
                    pila.Eliminar();
                    Imprimir(pila.ObtenerArreglo());
                    pila.Eliminar();
                    Imprimir(pila.ObtenerArreglo());
                    pila.Eliminar();
                    Imprimir(pila.ObtenerArreglo());
                    pila.Eliminar();
                    Imprimir(pila.ObtenerArreglo());
                    pila.Eliminar();
                    Imprimir(pila.ObtenerArreglo());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

            static void ArregloColas()
            {
                Arreglos.Colas cola = new Arreglos.Colas(5);

                void Imprimir(string[] elementos)
                {
                    //Console.Clear();
                    Console.WriteLine();
                    foreach (string elemento in elementos)
                    {
                        Console.WriteLine(elemento);
                    }
                }

                try
                {

                    cola.Agregar("Pablo0");
                    cola.Agregar("Pablo1");
                    cola.Agregar("Pablo2");
                    cola.Agregar("pablo3");
                    cola.Agregar("Pablo4");

                    Imprimir(cola.ObtenerArreglo());

                    cola.Eliminar();
                    Imprimir(cola.ObtenerArreglo());
                    cola.Eliminar();
                    Imprimir(cola.ObtenerArreglo());
                    cola.Eliminar();
                    Imprimir(cola.ObtenerArreglo());
                    cola.Eliminar();
                    Imprimir(cola.ObtenerArreglo());
                    cola.Eliminar();
                    Imprimir(cola.ObtenerArreglo());
                    cola.Eliminar();
                    Imprimir(cola.ObtenerArreglo());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
        }
    }





