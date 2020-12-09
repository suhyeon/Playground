using Toy.Mutable.Interfaces;

namespace Toy.Mutable.Implements
{
    public class Calculator : ICalculator
    {
        public MutableObject Add(MutableObject obj)
        {
            obj.Value++;
            return obj;
        }
    }
}
