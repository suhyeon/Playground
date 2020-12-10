namespace Toy.Immutable.Contracts
{
    public record Test(int Value)
    {
    }

    public class InitTest
    {
        public int Value { get; init; }
    }

    public record Another
    {
        public int Value { get; }
    }

}
