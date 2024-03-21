namespace ConsoleApp1;

public class ColdProduct : Product
{
    private double Temperature { get; }
    public ColdProduct(string name, ProductType type, double temperature) : base(name, type)
    {
        Temperature = temperature;
    }
}