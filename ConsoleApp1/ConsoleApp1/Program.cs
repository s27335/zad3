using ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        Product milk = new Product("milk", ProductType.Liquid);
        Product bananas = new ColdProduct("bananas", ProductType.Cold,13.3);
        
        LiquidContainer liquidContainer = new LiquidContainer(0,200,1000,300,600,false);
        LiquidContainer liquidContainer2 = new LiquidContainer(0,200,1000,300,600,false);
        liquidContainer.AddProduct(milk,910);
        liquidContainer2.AddProduct(milk,900);
        
    }



}