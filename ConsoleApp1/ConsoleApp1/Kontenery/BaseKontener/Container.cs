namespace ConsoleApp1;

public abstract class Container
{
    public double Weight { get; set; }
    public double NetWeight { get; set; }
    public double MaxWeight { get; }
    public int Height { get; set; }
    protected int Depth { get; set; }
    public string Id { get; set; }

    protected Container(double weight,double netWeight,double maxWeight,int height,int depth)
    {
        Weight = weight;
        NetWeight = netWeight;
        MaxWeight = maxWeight;
        Height = height;
        Depth = depth;
    }


    public abstract void DeleteProduct();
    public abstract void AddProduct(Product product,double weight);
    public abstract void GetInformation();






}