using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    public int Price { get; set; }
    public int Power { get; set; }
    public int Fuel { get; set; }

    public void Refuel()
    {
        Console.WriteLine("Метод для заправки авто був викликаний");
        Random rnd = new Random();
        int fuelTypeCode = rnd.Next(1, 4);

        switch (fuelTypeCode)
        {
            case 1:
                Console.WriteLine("Заправлено газом");
                break;
            case 2:
                Console.WriteLine("Заправлено бензином");
                break;
            case 3:
                Console.WriteLine("Заправлено дизелем");
                break;
        }
    }
    public void Drive()
    {
        Console.WriteLine("Метод 'їхати' був викликаний");
        Console.WriteLine("Жигуль їде");
    }

    public override string ToString()
    {
        return $"Price = {Price}, Power = {Power}, Fuel = {Fuel}";
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is Engine engine)
            return Price == engine.Price && Power == engine.Power && Fuel == engine.Fuel;
        return false;
    }



}
