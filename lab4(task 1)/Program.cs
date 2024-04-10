using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.WriteLine($"Марка авто: {car.Name}");
            Console.WriteLine();
            car.Wheel.ReplaceWheel();
            Console.WriteLine();
            car.Engine.Refuel();
            Console.WriteLine();
            car.Engine.Drive();
        }
    }
    public class Car
    {
        public string Name { get; } = "Жигуль";

        public Wheel Wheel { get; } = new Wheel();

        public Engine Engine { get; } = new Engine();
    }
}
