namespace ConsoleApp1;

public class Product
{
    private string Name { get; }
    private string Type { get; }

    public Product(string name, string type)
    {
        Name = name;
        Type = type;
    }
    
    
    public override string ToString()
    {
        return Name;
    }
}