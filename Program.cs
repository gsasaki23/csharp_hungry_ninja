using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja neil = new Ninja();

            while(!neil.IsFull)
            {
                Food dish = buffet.Serve();
                neil.Eat(dish);
            }
            Console.WriteLine("Neil is full...");
        }
    }
}
