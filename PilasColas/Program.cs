Arreglos.Pila pila = new Arreglos.Pila(5);

try
{
pila.Agregar("Pepe0");
pila.Agregar("Pepe1");
pila.Agregar("Pepe2");
pila.Agregar("Pepe3");
pila.Agregar("Pepe4");
pila.Agregar("Pepe5");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}