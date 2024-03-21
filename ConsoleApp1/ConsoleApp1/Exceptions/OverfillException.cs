namespace ConsoleApp1;

public class OverfillException : Exception
{
    public OverfillException()
    {
        
    }

    public OverfillException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}