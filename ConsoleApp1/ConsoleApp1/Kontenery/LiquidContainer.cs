namespace ConsoleApp1;

public class LiquidContainer : Container
{
    private List<Product> productsList;
    private string Id { get; }
    private static int idNum;

    public LiquidContainer(double weight, double netWeight, double maxWeight, int height, int depth) : base(weight, netWeight, maxWeight, height, depth)
    {
        Id = "KON-L-" + idNum;
        idNum++;
    }

    protected override void DeleteProduct(Product product)
    {
        productsList.Remove(product);
    }

    protected override void AddProduct(Product product, double weight)
    {
        
        if (product.Type.Equals("Liquid"))
        {
            productsList.Add(product);
            Weight += weight;
        }
        
    }
}