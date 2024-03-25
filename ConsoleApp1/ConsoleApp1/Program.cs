using System.Transactions;
using ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Product milk = new Product("milk", ProductType.Liquid);
            ColdProduct bananas = new ColdProduct("bananas", ProductType.Cold, 13.3);
            Product fuel = new Product("fuel", ProductType.Liquid);
            Product nitrogen = new Product("nitrogen", ProductType.Gas);

            LiquidContainer liquidContainer = new LiquidContainer(0, 250, 1000, 300, 600, false);
            LiquidContainer liquidContainer2 = new LiquidContainer(0, 250, 1000, 300, 600, false);
            ColdContainer coldContainer = new ColdContainer(0, 200, 1200, 300, 600, bananas, 14);
            GasContainer gasContainer = new GasContainer(0, 300, 800, 300, 600, 1);

            ContainerShip ship = new ContainerShip(100, 1000, 1200);
            ContainerShip ship2 = new ContainerShip(130, 800, 900);

            liquidContainer.AddProduct(milk, 910);
            liquidContainer2.AddProduct(milk, 900);
            coldContainer.AddProduct(bananas, 1000);
            gasContainer.AddProduct(nitrogen, 100);

            ship.LoadContainer(liquidContainer);
            List<Container> containers =new List<Container>(){ coldContainer, gasContainer };
            
            ship.LoadContainerList(containers);
            ship.DeleteContainer(gasContainer);

            gasContainer.DeleteProduct();
            gasContainer.GetInformation();

            liquidContainer.GetInformation();
            ship.SwapContainers("KON-L-0", liquidContainer2);

            ship.MoveContainer("KON-C-0", ship2);

            ship.GetInformation();
        }
        catch (Exception e) {}
    }



}