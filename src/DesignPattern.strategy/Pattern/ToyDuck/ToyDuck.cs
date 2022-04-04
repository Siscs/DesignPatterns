using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.strategy.Pattern.ToyDuck
{
    public class ToyDuck : Duck

    {
        public ToyDuck()
        {
            SetDuckBehavior(new ToyDuckBehavior());
            Voar();
            Grasnar();
        }

        public override void DisplayDuckType()
        {
            Console.WriteLine("Eu sou um toy duck !!!");
        }
    }
}
