namespace Ejercicio2;

class Concesionaria
{
  public List<Automovil> lista;
  public int limite;
  public int NoAct;

  Concesionaria(int limite){
    this.limite=limite;
    lista = new <Automovil>();
    this.NoAct=0;
  }

  public void AgregarAuto(Automovil a){
    if(NoAct<=limite){
        lista.add(a);
        NoAct=NoAct+1;
    }
   
  }

  public void MostrarAuto(Automovil a){
    Console.WriteLine(a.ToString());
  }

  public void EliminarAuto(Automovil a){
    if(NoAct<=limite && lista.Cout != 0){
        lista.Remove(a);
        NoAct=NoAct-1;
    }
    
  }

  public void MostrarAutos(){
    foreach (Automovil item in lista)
    {
        Console.WriteLine(item.ToString());
    }

    public void VaciarConcesionaria(){
        lista.clear();
    }
  }
}
