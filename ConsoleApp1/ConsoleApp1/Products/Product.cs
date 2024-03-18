namespace ConsoleApp1;

public class Product
{
    public string Name { get; }
    public Type Type { get; }

    public Product(string name, Type type)
    {
        Name = name;
        Type = type;
    }
    
    
    public override string ToString()
    {
        return Name;
    }
}