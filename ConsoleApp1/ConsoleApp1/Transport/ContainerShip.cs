namespace ConsoleApp1;

public class ContainerShip
{
    public List<Container> Containers { get; }
    public double MaxSpeed { get; }
    public int MaxContainerAmount { get; }
    public double MaxContainerWeight { get; }
    
    public ContainerShip(double maxSpeed,int maxContainerAmount, double maxContainerWeight)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainerAmount = maxContainerAmount;
        MaxContainerWeight = maxContainerWeight;
    }

    public void LoadContainer()
    {
        
    }
    
}