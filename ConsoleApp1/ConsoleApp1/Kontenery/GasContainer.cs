﻿using System.Xml.Resolvers;
using System.Xml.Schema;

namespace ConsoleApp1;

public class GasContainer: Container, IHazardNotifier
{
    private List<Product> GasList;
    private string Id { get; }
    private static int idNum;
    private double Pressure { get; }
    

    public GasContainer(double weight, double netWeight, double maxWeight, int height, int depth,double pressure) : base(weight, netWeight, maxWeight, height, depth)
    {
        GasList = new List<Product>();
        Pressure = pressure;
        Id = "KON-G-" + idNum;
        idNum++;
    }

    public override void DeleteProduct()
    {
        Weight*=0.05;
    }

    public override void AddProduct(Product product, double pWeight)
    {
        if (pWeight+Weight > MaxWeight)
        {
            throw new OverfillException("Container " + Id + " overfilled!");
        }
        
        if (product.ProdType.Equals(ProductType.Gas))
        {
            if (GasList.Contains(product) | GasList.Count==0)
            {
                GasList.Add(product);   
                Weight += pWeight;
            }
            else
            {
                Console.WriteLine("Container already contains other type of gas!");
            }
            
        }
        
    }

    public void SendMessage()
    {
        Console.WriteLine("Container: " + Id + " might be in a dangerous situation");
    }
}