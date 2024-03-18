namespace ConsoleApp1;

public abstract class Container
{
    protected double Weight { get; set; }
    protected double NetWeight { get; set; }
    protected double MaxWeight { get; }
    protected int Height { get; set; }
    protected int Depth { get; set; }


    protected Container(double weight,double netWeight,double maxWeight,int height,int depth)
    {
        Weight = weight;
        NetWeight = netWeight;
        MaxWeight = maxWeight;
        Height = height;
        Depth = depth;
    }


    protected abstract void DeleteProduct(string product);
    protected abstract void AddProduct(string product,double weight);
    







}