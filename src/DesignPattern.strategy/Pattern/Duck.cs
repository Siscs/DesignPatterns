using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.strategy.Pattern
{
    public abstract class Duck
    {
        IDuckBehavior _duckBehavior;

        public Duck()
        {
            DisplayDuckType();
        }

        public void Voar()
        {
            _duckBehavior.Voar();
        }

        public void Grasnar()
        {
            _duckBehavior.Grasnar();
        }

        public abstract void DisplayDuckType();

        public void SetDuckBehavior(IDuckBehavior duckBehavior)
        {
            _duckBehavior = duckBehavior;
        }

    }




}
