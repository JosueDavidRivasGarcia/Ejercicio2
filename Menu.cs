namespace Ejercicio2;

public class Menu{
    Concesionaria concesionaria = new Concesionaria(10);
    public bool showMenu(){
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
                agregarAuto();
                Console.ReadLine();
                return true;
            case "2": 
                eliminarAutomovil();
                Console.ReadLine();
                return true;
            case "3": 
                buscarAutomovil();
                Console.ReadLine();
                return true;
            case "4": 
                mostrarAutomoviles();
                Console.ReadLine();
                return true;
            case "5": 
               return false;
            default:
                return true;
        }

    }

    public void agregarAuto()
        {
        Console.Clear();
        Console.WriteLine("CREANDO NUEVO AUTOMOVIL");
        Console.WriteLine("ID: ");
        string? id = Console.ReadLine();
        Console.WriteLine("Marca: ");
        string? marca = Console.ReadLine();
        Console.WriteLine("Modelo: ");
        string? modelou = Console.ReadLine();
        Console.WriteLine("Km: ");
        string? kilo = Console.ReadLine();
        Console.WriteLine("Precio: ");
        string? precio = Console.ReadLine();

       Automovil nuevo = new Automovil(
            id,
            marca,
            modelou,
            int.Parse(kilo),
            double.Parse(precio)
        );
        concesionaria.AgregarAutomovil(nuevo);
        Console.WriteLine("El auto se agrego correctamente");
        
    }

      public void eliminarAutomovil()
        {
            Console.Clear();
            Console.Write("ID: ");
            string? id = Console.ReadLine();
            concesionaria.EliminarAuto(id);
            Console.WriteLine("Automovil eliminado correctamente");
        }

        public void mostrarAutomoviles(){
            Console.Clear();
            concesionaria.MostrarAutomoviles();

        }

        public void buscarAutomovil(){
            Console.Clear();
            Console.Write("ID: ");
            string? id = Console.ReadLine();
            concesionaria.MostrarAuto(id);

        }
    
}