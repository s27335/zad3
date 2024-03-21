namespace ConsoleApp1;

public abstract class Container
{
    protected Dictionary<Product,double> productDic { get; }
    protected double Weight { get; set; }
    protected double NetWeight { get; set; }
    protected double MaxWeight { get; }
    protected int Height { get; set; }
    protected int Depth { get; set; }


    protected Container(double weight,double netWeight,double maxWeight,int height,int depth)
    {
        this.productDic = new Dictionary<Product, double>();
        Weight = weight;
        NetWeight = netWeight;
        MaxWeight = maxWeight;
        Height = height;
        Depth = depth;
    }


    public abstract void DeleteProduct(Product product);
    public abstract void AddProduct(Product product,double weight);
    







}