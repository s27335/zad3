namespace ConsoleApp1;

public class ColdContainer: Container
{
    public List<Product> ProductList { get; }
    public ColdProduct AllowedProduct { get; }
    public double ContainerTemp { get; set; }
    public string Id { get; }
    private static int idNum;

    public ColdContainer(double weight, double netWeight, double maxWeight, int height,int depth, ColdProduct allowedProduct,double containerTemp) : base(weight, netWeight, maxWeight, height, depth)
    {
        if (containerTemp < allowedProduct.Temperature)
        {
            throw new TemperatureException("Temperature of container must be equal or higher than temperature of given product");
        }
        AllowedProduct = allowedProduct;
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
        
        if (product.ProdType.Equals(ProductType.Cold) && product.Name == AllowedProduct.Name)
        {
            
                ProductList.Add(product);   
                Weight += pWeight;
                
        }
        else
        {
            Console.WriteLine("Container can only storage: " + AllowedProduct.Name + "!");
        }
        
    }
    
    
}