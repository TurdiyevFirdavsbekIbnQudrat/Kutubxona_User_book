using System;
namespace Polymorphism
{
    public class Asus : Laptop
    {
        public Asus()
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine("Asus logo");
        }

        public new void TurnOff()
        {
            Console.WriteLine("Asus turning off");
        }
    }
}