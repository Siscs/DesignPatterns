using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.strategy.Pattern.ToyDuck
{
    public class ToyDuckBehavior : IDuckBehavior
    {
        public void Grasnar()
        {
            Console.WriteLine("Toy duck não grasna.");
        }

        public void Voar()
        {
            Console.WriteLine("Toy duck não voa...");
        }
    }
}
