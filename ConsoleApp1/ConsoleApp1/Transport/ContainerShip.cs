namespace ConsoleApp1;

public class ContainerShip
{
    public List<Container> Containers { get; }
    public double MaxSpeed { get; }
    public int MaxContainerAmount { get; }
    public double MaxContainerWeight { get; }
    public double Weight { get; set; }
    
    public ContainerShip(double maxSpeed,int maxContainerAmount, double maxContainerWeight)
    {
        Weight = 0;
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainerAmount = maxContainerAmount;
        MaxContainerWeight = maxContainerWeight;
    }

    public void LoadContainer(Container container)
    {
        double tempWeight = (container.Weight + container.NetWeight) / 1000 + Weight;
        
        if ( tempWeight > MaxContainerWeight)
        {
            throw new ContainerShipOverfillException("Weight of container ship to big!");
        }
        
        Containers.Add(container);
        Weight = tempWeight;
        
    }
    
    public void LoadContainerList(List<Container> containerList)
    {
        double tempWeight = Weight;
        foreach (var container in containerList)
        {
            tempWeight += (container.Weight + container.NetWeight) / 1000;
        }
            
        
        if ( tempWeight > MaxContainerWeight)
        {
            throw new ContainerShipOverfillException("Weight of container ship to big!");
        }

        foreach (var container in containerList)
        {
            Containers.Add(container);
        }
        Weight = tempWeight;
        
    }

    public void DeleteContainer(string containerId)
    {
        bool exists = false;
        foreach (var container in Containers)
        {
            if (container.Id == containerId)
            {
                Containers.Remove(container);
                exists = true;
                break;
            }
        }

        if (!exists)
        {
            Console.WriteLine("Container does not exist!");
        }
    }

    public void SwapContainers(string containerId, Container anotherContainer)
    {
        int index = 0;
        foreach (var container in Containers)
        {
            if (container.Id == containerId)
            {
                Containers[index] = anotherContainer;
                break;
            }

            index++;
        }
    }

    public void MoveContainer(string containerId, ContainerShip anotherShip)
    {
        bool exists = false;
        foreach (var container in Containers)
        {
            if (container.Id == containerId)
            {
                anotherShip.Containers.Add(container);
                Containers.Remove(container);
                exists = true;
                break;
            }
        }

        if (!exists)
        {
            Console.WriteLine("Container does not exist!");
        }
        
    }

    public void GetInformation()
    {
        Console.WriteLine("Container ship with max speed: " + MaxSpeed + ", MaxWeight: " + MaxContainerWeight + "t and containers: ");
        foreach (var container in Containers)
        {
            Console.Write("|" + container.Id + "| ");
        }
    }
    
}