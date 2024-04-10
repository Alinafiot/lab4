using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    public class Wheel
    {
        public int Price { get; set; }
        public int CountWheel { get; set; }
        public int SummerOrWinter { get; set; }


        public void ReplaceWheel()
        {
            Console.WriteLine("Метод для замiни колеса був викликаний");
            Random rand = new Random();
            int wheelNumber = rand.Next(1, 5);
            Console.WriteLine($"Замiнено колесо номер {wheelNumber}");
        }
        public override string ToString()
        {
            return $"Price = {Price}, CountWheel = {CountWheel}, SummerOrWinter = {SummerOrWinter}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Wheel wheel)
                return Price == wheel.Price && CountWheel == wheel.CountWheel && SummerOrWinter == wheel.SummerOrWinter;
            return false;
        }
    }
}