using ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        Product milk = new Product("milk", ProductType.Liquid);
        LiquidContainer liquidContainer = new LiquidContainer(0,200,1000,300,600,false);
        LiquidContainer liquidContainer2 = new LiquidContainer(0,200,1000,300,600,false);
        liquidContainer.AddProduct(milk,910);
        liquidContainer2.AddProduct(milk,900);
    }



}