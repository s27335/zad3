namespace ConsoleApp1;

public class ColdContainer: Container, IHazardNotifier
{
    private string Id { get; }
    private static int idNum;

    public ColdContainer(double weight, double netWeight, double maxWeight, int height, int depth) : base(weight, netWeight, maxWeight, height, depth)
    {
        Id = "KON-C-" + idNum;
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
        
        if (product.Type.Equals(ProductType.Cold))
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

    public void SendMessage()
    {
        Console.WriteLine("Container: " + Id + " in a dangerous situation");
    }
}