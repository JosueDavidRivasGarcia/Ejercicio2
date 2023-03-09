namespace Ejercicio2;

class Automovil
{
    public string ID {get; set;}
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int Km {get; set;}
    public double Precio {get; set;}

    public override string ToString()
    {
        return $"ID: {this.ID}, Marca: {this.Marca}, Modelo: {this.Modelo}, KM: {this.Km}, Precio: {this.Precio} ";
    }

}
