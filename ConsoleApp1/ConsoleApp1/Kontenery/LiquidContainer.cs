namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    private List<Product> LiquidList { get; }
    private string Id { get; }
    private static int idNum;
    private bool IsDangerous { get; }

    public LiquidContainer(double weight, double netWeight, double maxWeight, int height, int depth,bool isDangerous) : base(weight, netWeight, maxWeight, height, depth)
    {
        LiquidList = new List<Product>();
        IsDangerous = isDangerous;
        Id = "KON-L-" + idNum;
        idNum++;
    }

    public override void DeleteProduct()
    {
        Weight = 0;
        LiquidList.Clear();
    }

    public override void AddProduct(Product product, double pWeight)
    {
        
        if (pWeight+Weight > MaxWeight)
        {
            throw new OverfillException("Container " + Id + " overfilled!");
        }
        
        if (product.ProdType.Equals(ProductType.Liquid))
        {
            if (IsDangerous && pWeight+Weight > 0.5*MaxWeight)
            {
                SendMessage();
            }
            else if (pWeight+Weight > 0.9*MaxWeight)
            {
                SendMessage();
            }
            else
            {
                if (LiquidList.Contains(product) | LiquidList.Count==0)
                {
                    LiquidList.Add(product);   
                    Weight += pWeight;
                }
                else
                {
                    Console.WriteLine("Container already contains other type of liquid!");
                }
                
            }
        }
        
    }

    public void SendMessage()
    {
        Console.WriteLine("Container: " + Id + " in a dangerous situation");
    }
}