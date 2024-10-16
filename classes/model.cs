public class God
{
    public string Name {get; set;}
    public string Reality {get; set;}
    public string Species {get; set;} 

        public God(string name, string reality, string species)
    {
        Name = name;
        Reality = reality;
        Species = species;
    }

        public override string ToString()
    {
        return $"Name: {Name}, Power Level: {Reality}, Type: {Species}";
    }

}


public class Model
{
     public List<God> gods;

     public Model()
     {
        gods = new List<God>
        {
           new God("Azathoth", "0", "Other God"),
           new God("Yog-Sothoth", "1", "Outer God"),
           new God("Nyalathotep", "5", "Outer God"),
           new God("Cthulhu", "8", "Great old one")
        }; 

        
     }

}