namespace InterfacesDemo;

public class Dog : IAnimal, IDog
{
    public int Age { get; set; }
    public string Diet { get; set; }
    public string Owner { get; set; }
    public string Breed { get; set; }
    
    public void Move()
    {
        Console.WriteLine("Dog is running!");
    }

    public void Breathe()
    {
        Console.WriteLine("Dog is breathing!");
    }

    
}