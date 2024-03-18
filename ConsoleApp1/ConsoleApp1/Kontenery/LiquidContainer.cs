namespace ConsoleApp1.Kontenery;

public class LiquidContainer : Container
{
    private List<string> productsList;
    private string Id { get; }
    private static int idNum;

    public LiquidContainer(double weight, double netWeight, double maxWeight, int height, int depth) : base(weight, netWeight, maxWeight, height, depth)
    {
        Id = "KON-L-" + idNum;
        idNum++;
    }

    protected override void DeleteProduct(string product)
    {
        productsList.Remove(product);
    }

    protected override void AddProduct(string product, double weight)
    {
        productsList.Add(product);
        Weight += weight;
    }
}