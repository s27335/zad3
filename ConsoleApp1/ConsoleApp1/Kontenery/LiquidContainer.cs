namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    private List<Product> productsList;
    private string Id { get; }
    private static int idNum;
    private bool isDangerous;

    public LiquidContainer(double weight, double netWeight, double maxWeight, int height, int depth,bool isDangerous) : base(weight, netWeight, maxWeight, height, depth)
    {
        this.isDangerous = this.isDangerous;
        Id = "KON-L-" + idNum;
        idNum++;
    }

    protected override void DeleteProduct(Product product)
    {
        productsList.Remove(product);
    }

    protected override void AddProduct(Product product, double pWeight)
    {
        
        if (pWeight+Weight > MaxWeight)
        {
            throw new OverfillException();
        }
        
        if (product.Type.Equals(ProductType.Liquid))
        {
            if (isDangerous && pWeight+Weight > 0.5*MaxWeight)
            {
                SendMessage();
            }
            else if (pWeight+Weight > 0.9*MaxWeight)
            {
                SendMessage();
            }
            else
            {
                productsList.Add(product);
                Weight += pWeight;
            }
        }
        
    }

    public void SendMessage()
    {
        Console.WriteLine("Container: " + Id + " in a dangerous situation");
    }
}