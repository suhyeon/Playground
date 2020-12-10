using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toy.Immutable;
using Toy.Immutable.Contracts;

namespace PlaygroundCore.Immutable
{
    [TestClass]
    public class ToyRecord_specs
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var a = new ImmutableObject(5);
            var b = new ImmutableObject(5);
            var t = new Test(5);
            var s = new Test(5);

            var i = new InitTest { Value = 5 };

            Assert.AreEqual(t, s);
            Assert.AreEqual(a, b);
            Assert.IsTrue(t.Equals(s));
            int g = t.GetHashCode();
            Assert.AreEqual(g, 2);
        }
    }
}
