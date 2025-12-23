namespace InterfacesDemo;

public interface IAnimal
{
    // Cannot have fields in an interface

    public int Age { get; set; }
    public string Diet { get; set; }
    
    // interface methods will ALWAYS by stubbed out methods (no scope)
    // In the background Interfaces are completely abstract (even though we never use the keyword abstract)

    public void Move();
    public void Breathe();
}