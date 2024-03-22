namespace ConsoleApp1;

public class ContainerShipOverfillException : Exception
{
    public ContainerShipOverfillException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}