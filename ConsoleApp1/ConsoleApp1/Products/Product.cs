namespace ConsoleApp1;

public class Product
{
    public string Name { get; }
    public ProductType ProdType { get; }

    public Product(string name, ProductType prodType)
    {
        Name = name;
        ProdType = prodType;
    }
    
    
    public override string ToString()
    {
        return Name;
    }
}