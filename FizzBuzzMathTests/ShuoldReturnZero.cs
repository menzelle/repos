using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace FizzBuzzMathTests
{
    [TestClass]
    public class ShouldReturnZero
    {
        [TestMethod]
        public void WhenDivisbleByBoth()
        {
            var mm = new FizzBuzzByMJ.MathMethods();

            var result = mm.MathMethod(15);
            Assert.IsTrue(result == "3 & 5");
             
        }
        [TestMethod]
        public void WhenDivisbleByThree()
        {
            var mm = new FizzBuzzByMJ.MathMethods();

            var result = mm.MathMethod(9);
            Assert.IsTrue(result == "3");

        }
        [TestMethod]
        public void WhenDivisbleByFive()
        {
            var mm = new FizzBuzzByMJ.MathMethods();

            var result = mm.MathMethod(10);
            Assert.IsTrue(result == "5");

        }
    }
}
