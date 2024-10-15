class Program 
{
     static void Main(string[] args)
     {
        View view = new View();
        Model model = new Model();

           List<God> gods = model.gods;
        
        view.displayGods(gods);

     }
}