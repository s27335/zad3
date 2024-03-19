namespace ConsoleApp1;

public class Product
{
    public string Name { get; }
    public ProductType Type { get; }

    public Product(string name, ProductType type)
    {
        Name = name;
        Type = type;
    }
    
    
    public override string ToString()
    {
        return Name;
    }
}