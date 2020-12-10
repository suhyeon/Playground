namespace Toy.Immutable.Contracts
{
    public class ClassType
    {
        public ClassType(int number,
                         string name,
                         Test immutableObject,
                         bool isImmutable,
                         int[] values)
        {
            Number = number;
            Name = name;
            ImmutableObject = immutableObject;
            IsImmutable = isImmutable;
            Values = values;
        }

        public int Number { get; }

        public string Name { get; }

        public Test ImmutableObject { get; }

        public bool IsImmutable { get; }

        public int[] Values { get; }

        public override string ToString()
        {
            return $"Number = {Number}, Name = {Name}, ImmutableObject = {ImmutableObject}, IsImmutable = {IsImmutable}, Values = {Values}";
        }
    }

    public record RecordType(int Number,
                             string Name,
                             Test ImmutableObject,
                             bool IsImmutable,
                             int[] Values)
    {
    }
}
