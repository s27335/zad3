namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    private string Id { get; }
    private static int idNum;
    private bool isDangerous;

    public LiquidContainer(double weight, double netWeight, double maxWeight, int height, int depth,bool isDangerous) : base(weight, netWeight, maxWeight, height, depth)
    {
        this.isDangerous = isDangerous;
        Id = "KON-L-" + idNum;
        idNum++;
    }

    public override void DeleteProduct(Product product)
    {
        Weight -= productDic[product];
        productDic.Remove(product);
    }

    public override void AddProduct(Product product, double pWeight)
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
                if (productDic.ContainsKey(product))
                {
                    productDic[product] += pWeight;
                }
                else
                { 
                    productDic.Add(product,pWeight);
                }
                
                Weight += pWeight;
            }
        }
        
    }

    public void SendMessage()
    {
        Console.WriteLine("Container: " + Id + " in a dangerous situation");
    }
}