namespace Polymorphism
{
    public class PrimeCalculator
    {
        public virtual bool IsPrime(int value)
        {
            var isPrime = value <= 1 ? false : true;
            for (var index = 2; index < value; index++)
            {
                Thread.Sleep(1000);
                if (value % index == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }

    public class FasterPrimeCalculator : PrimeCalculator
    {
        public override bool IsPrime(int value)
        {
            var isPrime = value <= 1 ? false : true;
            for (var index = 2; index <= Math.Sqrt(value); index++)
            {
                Thread.Sleep(1000);
                if (value % index == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
