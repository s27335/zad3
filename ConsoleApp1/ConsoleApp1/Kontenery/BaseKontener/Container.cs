namespace ConsoleApp1;

public abstract class Container
{
    protected double Weight { get; set; }
    protected double NetWeight { get; set; }
    protected double MaxWeight { get; }
    protected int Height { get; set; }
    protected int Glebokosc { get; set; }


    protected Container(double weight,double netWeight,double maxWeight,int height,int depth)
    {
        Masa = masa;
        MasaWlasna = masaWlasna;
        MaxLadownosc = maxLadownosc;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
    }


    protected abstract void oprozLadunek();
    protected abstract void zaladujLadunek();
    







}