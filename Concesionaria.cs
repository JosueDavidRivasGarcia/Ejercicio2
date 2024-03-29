namespace Ejercicio2;

class Concesionaria
{
  

  public Concesionaria(int limite){
    Automoviles=new List<Automovil>();
    this.limite=limite;
    NoAct=0;
  }

  public List<Automovil> Automoviles {get; set;}
  public int limite {get; set;}
  public int NoAct {get; set;}

  public void AgregarAutomovil(Automovil a)
  {
    if(a!=null && NoAct!=limite){
      Automovil? AutoEncontrado=Automoviles.Find((b)=>b.ID==a.ID);
      if(AutoEncontrado==null){
        Automoviles.Add(a);
        NoAct=NoAct+1;
      }
    }
  }
  public void EliminarAuto(string ID){
      if(ID!=""&&NoAct!=0){
          Automovil? AutoEncontrado=Automoviles.Find((a)=>a.ID==ID);
          /*
          (a)->a.ID==ID
          function(Automovil a){
            if(a.ID==ID)
              return a;
          }
          */
          if(AutoEncontrado!= null){
          Automoviles.Remove(AutoEncontrado);
          NoAct--;
          }
      }
  }

 public void MostrarAuto(string ID){
    Automovil? AutoEncontrado=Automoviles.Find((a)=>a.ID==ID);
    if(AutoEncontrado != null)
     Console.WriteLine(AutoEncontrado.ToString());
  }

  public void MostrarAutomoviles(){
    foreach (Automovil item in Automoviles)
    {
      Console.WriteLine(item.ToString());
    }
  }

  public void VaciarConsecionaria(){
    Automoviles.Clear();
    NoAct=0;
  }
}