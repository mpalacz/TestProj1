namespace TestProj1
{
    [TestClass]
    public class UnitTest1
    {
        double a = 1.454458;
        double b = -84.32;
        [TestMethod]
        public void TestMethod_add()
        {
            double expected = -82.86542;
            double actual = MathOperations.addition(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_subtract()
        {
            double expected = 85.774458;
            double actual = MathOperations.subtractition(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}