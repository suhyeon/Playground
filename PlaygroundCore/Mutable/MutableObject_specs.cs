using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toy.Mutable;
using Toy.Mutable.Implements;
using Toy.Mutable.Interfaces;

namespace PlaygroundCore.Mutable
{

    public class MyPrinter : ICalculator
    {
        private readonly ICalculator _calculator;
        private readonly TestContext _context;

        public MyPrinter(ICalculator calculator, TestContext context)
        {
            _calculator = calculator;
            _context = context;
        }

        public TestContext Context { get; set; }

        public MutableObject Add(MutableObject obj)
        {
            var result = _calculator.Add(obj);

            _context.WriteLine($"Value: {result.Value}");

            return result;
        }
    }

    [TestClass]
    public class ImmutableOjbect_specs
    {
        public TestContext TestContext { get; set; }

        public ICalculator Decorator { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Decorator = new MyPrinter(new Calculator(), TestContext);
        }

        [TestMethod]
        public void Add_method_must_add_one_more()
        {
            var obj = new MutableObject { Value = 13 };
            Decorator.Add(obj);
        }

        [TestMethod]
        public void If_the_same_value_is_used_then_the_result_should_always_be_the_same()
        {
            var obj = new MutableObject { Value = 13 };
            Decorator.Add(obj);
            Decorator.Add(obj);
        }
    }
}