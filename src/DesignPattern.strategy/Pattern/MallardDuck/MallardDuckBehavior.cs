using System;

namespace DesignPattern.strategy.Pattern.MallardDuck
{
    public class MallardDuckBehavior : IDuckBehavior
    {
        public void Grasnar()
        {
            Console.WriteLine("Mallard duck: Quack Quack..");
        }

        public void Voar()
        {
            Console.WriteLine("Mallard duck voando");
        }
    }
}
