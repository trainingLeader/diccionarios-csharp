using diccionarios_csharp;

public class DiccDemo{
    private Dictionary<string,Persona> person = new Dictionary<string,Persona>();

    public Dictionary<string, Persona> Person { get => person; set => person = value; }

    public void AddItem(string id,Persona person){
        this.Person.Add(id,person);
    }
    public void ViewData(){
        
    }
    public void ViewData(int opcion){
        switch(opcion){
            case 0:
                Dictionary<string,Persona>.KeyCollection llave = this.Person.Keys;
                foreach(string key in llave){
                    Console.WriteLine("{0}",key);
                }
                break;
            case 1:
                Dictionary<string,Persona>.ValueCollection valor = this.Person.Values;
                foreach(Persona p in valor){
                    Persona p2 = p;
                    Console.WriteLine("{0}",p2.Id);
                    Console.WriteLine("{0}",p2.Name);
                    Console.WriteLine("{0}",p2.EmailAddress);
                }
                Console.ReadKey();
                break;
            case 2:
                foreach(KeyValuePair<string,Persona> par in person){
                    Console.WriteLine("{0} - {1}",par.Key,par.Value.Name);
                }
                break;
        }
    }
}