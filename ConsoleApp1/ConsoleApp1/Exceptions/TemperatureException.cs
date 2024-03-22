namespace ConsoleApp1;

public class TemperatureException : Exception
{
    public TemperatureException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}