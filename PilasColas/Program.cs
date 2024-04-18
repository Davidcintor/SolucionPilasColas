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
            ListasPilas();
            ListasColas();
        }


        static void ArregloPila()
        {
            Console.WriteLine("---Arreglo Pila---");
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

                pila.Agregar("Mariana 0");
                pila.Agregar("Mariana 1");
                pila.Agregar("Mariana 2");
                pila.Agregar("Mariana 3");
                pila.Agregar("Mariana 4");

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

            Console.WriteLine("---------");
        }


        static void ArregloColas()
        {
            Console.WriteLine("---Arreglos Colas---");
            Arreglos.Colas cola = new Arreglos.Colas(5);

            void Imprimir(string[] elementos)
            {
                Console.WriteLine();
                foreach (string elemento in elementos)
                {
                    Console.WriteLine(elemento);
                }
            }

            try
            {

                cola.Agregar("Elisa 0");
                cola.Agregar("Elisa 1");
                cola.Agregar("Elisa 2");
                cola.Agregar("Elisa 3");
                cola.Agregar("Elisa 4");

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

            Console.WriteLine("---------");
        }


        static void ListasPilas()
        {
            Console.WriteLine("---Listas Pilas---");
            try
            {

                Listas.Pilas pila = new Listas.Pilas();

                pila.Agregar("Yamil 0");
                pila.Imprimir();
                pila.Agregar("Yamil 1");
                pila.Imprimir(); ;
                pila.Agregar("Yamil 2");
                pila.Imprimir();
                pila.Agregar("Yamil 3");
                pila.Imprimir();
                pila.Agregar("Yamil 4");
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());

                Console.WriteLine();
                pila.Eliminar();
                Console.WriteLine(pila.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("---------");
        }

        static void ListasColas()
        {
            Console.WriteLine("---Listas Colas---");
            try
            {

                Listas.Colas cola = new Listas.Colas();

                cola.Agregar("David 0");
                cola.Imprimir();
                cola.Agregar("David 1");
                cola.Imprimir(); ;
                cola.Agregar("David 2");
                cola.Imprimir();
                cola.Agregar("David 3");
                cola.Imprimir();
                cola.Agregar("David 4");
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());

                Console.WriteLine();
                cola.Eliminar();
                Console.WriteLine(cola.Imprimir());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}






