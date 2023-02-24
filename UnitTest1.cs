namespace TestProj1
{
    [TestClass]
    public class UnitTest1
    {
        double a = 1.454458;
        double b = -84.32;
        double expected, actual;
        [TestMethod]
        public void TestMethod_add()
        {
            expected = -82.86542;
            actual = MathOperations.addition(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_sub()
        {
            expected = 85.774458;
            actual = MathOperations.subtractition(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_mul()
        {
            expected = -122.63989856;
            actual = MathOperations.multiplication(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_div()
        {
            expected = -0.0172492647058824;
            actual = MathOperations.division(a, b);
            Assert.AreEqual(expected, actual, 0.001);
        }
        [TestMethod]
        public void TestMethod_divByZero()
        {
            actual = MathOperations.division(a, 0);
            Assert.AreEqual(0, actual);
        }

    }
}