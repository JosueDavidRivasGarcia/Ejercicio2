namespace Ejercicio2;

class Automovil
{
    public string ID;
    public string Marca;
    public int Modelo;
    public int Km;
    public double Precio;

    public override string ToString()
    {
        return $"ID: {ID}, Marca: {Marca}, Modelo: {Modelo}, KM: {Km}, Precio: {Precio} ";
    }

}
