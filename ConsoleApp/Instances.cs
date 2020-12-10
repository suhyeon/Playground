using System;
using Toy.Immutable.Contracts;

namespace ConsoleApp
{
    public class Instances
    {
        static void Main()
        {
            var immutableClass = new ClassType(4, "", new Test(2), true, new[] { 1, 2, 3 });
            var immutableRecord = new RecordType(4, "", new Test(2), true, new[] { 1, 2, 3 });

            Console.WriteLine($"{immutableClass}");
            Console.WriteLine($"{immutableRecord}");

            var newImmutableClass = new ClassType(2,
                                                  "d",
                                                  immutableClass.ImmutableObject,
                                                  immutableClass.IsImmutable,
                                                  immutableClass.Values);
            var newImmutableRecord = immutableRecord with { Number = 2, Name = "d" };

            Console.WriteLine($"{newImmutableClass}");
            Console.WriteLine($"{newImmutableRecord}");
        }
    }
}
