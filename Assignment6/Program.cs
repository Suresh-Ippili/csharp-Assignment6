

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Medium", 2, 1, 0);
            Pizza pizza2 = new Pizza("Large", 1, 2, 1);
            Console.WriteLine("Pizza 1:");
            Console.WriteLine(pizza1.GetDescription());
            Console.WriteLine($"Cost: ${pizza1.CalcCost()}");

            Console.WriteLine("\nPizza 2:");
            Console.WriteLine(pizza2.GetDescription());
            Console.WriteLine($"Cost: ${pizza2.CalcCost()}");

        }
    }
}


