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