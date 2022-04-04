using System;

namespace DesignPattern.strategy.Pattern.MallardDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetDuckBehavior(new MallardDuckBehavior());
            Voar();
            Grasnar();
        }

        public override void DisplayDuckType()
        {
            Console.WriteLine("Eu sou um mallard duck !!!");
        }
    }




}
