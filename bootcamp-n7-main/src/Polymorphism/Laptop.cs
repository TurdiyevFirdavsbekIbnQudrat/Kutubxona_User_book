using Polymorphism;

namespace Polymorphism
{
    public class Laptop
    {
        //public string TaskManager { get; set; }

        //protected string Bios { get; set; }

        private string Admin { get; set; }

        //protected internal string Test { get; set; }

        //internal string TestA { get; set; }

        //private protected string TestC { get; set; }

        //public string GetAdmin ()
        //{
        //    return Admin;
        //}

        public virtual void TurnOn()
        {
            Console.WriteLine("BIOS logo");
        }

        public void TurnOff()
        {
            Console.WriteLine("Laptop turning off");
        }
    }
}

public class Desktop
{

}
