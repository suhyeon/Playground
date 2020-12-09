namespace Toy.Immutable
{
    public class ImmutableObject
    {
        public ImmutableObject(int value) => Value = value;

        public int Value { get; }
    }
}
