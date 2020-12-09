using Toy.Immutable.Interfaces;

namespace Toy.Immutable.Implements
{
    public class Calculator : ICalculator
    {
        public ImmutableObject Add(ImmutableObject obj)
        {
            return new ImmutableObject(obj.Value + 1);
        }
    }
}
