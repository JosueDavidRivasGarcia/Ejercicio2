namespace Ejercicio2;

class Automovil
{
    public Automovil(string iD, string marca, string modelo, int km, double precio)
    {
        ID = iD;
        Marca = marca;
        Modelo = modelo;
        Km = km;
        Precio = precio;
    }

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

