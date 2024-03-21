namespace ConsoleApp1;

public class ColdContainer: Container, IHazardNotifier
{
    private List<Product> ProductList { get; }
    public double ContainerTemp { get; set; }
    private string Id { get; }
    private static int idNum;

    public ColdContainer(double weight, double netWeight, double maxWeight, int height,int depth,double containerTemp) : base(weight, netWeight, maxWeight, height, depth)
    {
        ContainerTemp = containerTemp;
        ProductList = new List<Product>();
        Id = "KON-C-" + idNum;
        idNum++;
    }

    public override void DeleteProduct()
    {
        Weight = 0;
        ProductList.Clear();
    }

    public override void AddProduct(Product product, double pWeight)
    {
        
        if (pWeight+Weight > MaxWeight)
        {
            throw new OverfillException("Container " + Id + " overfilled!");
        }
        
        if (product.ProdType.Equals(ProductType.Cold))
        {
            if (
                ProductList.Contains(product) | ProductList.Count==0)
            {
                ProductList.Add(product);   
                Weight += pWeight;
            }
            else
            {
                Console.WriteLine("Container already contains other type of product!");
            }
        }
        
    }

    public void SendMessage()
    {
        Console.WriteLine("Container: " + Id + " in a dangerous situation");
    }
}