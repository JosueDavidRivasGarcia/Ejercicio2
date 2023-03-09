namespace Ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
    }

    public bool Menu(){
        Console.Clear();
        Console.WriteLine("Seleccione una opcion: ");
        Console.WriteLine("1.- Agragar automovil");
        Console.WriteLine("2.- Eliminar automovil ");
        Console.WriteLine("3.- Buscar autoovil ");
        Console.WriteLine("4.- Listar todos ");
        Console.WriteLine("5.- Salir ");
        Console.WriteLine("Opcion: ");

        switch(Console.ReadLine())
        {
            case "1": 
                Console.WriteLine("Seleccionaste 1");
                Console.ReadLine();
                break;
            case "2": 
                Console.WriteLine("Seleccionaste 2");
                Console.ReadLine();
                break;
            case "3": 
                Console.WriteLine("Seleccionaste 3");
                Console.ReadLine();
                break;
            case "4": 
                Console.WriteLine("Seleccionaste 4");
                Console.ReadLine();
                break;
        }
        return true;

    }
}