using DesignPattern.strategy.Pattern.MallardDuck;
using DesignPattern.strategy.Pattern.ToyDuck;
using System;

namespace DesignPattern.strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Strategy design pattern (duck example).");

            new MallardDuck();
            new ToyDuck();

            Console.ReadLine();
        }
    }
}
