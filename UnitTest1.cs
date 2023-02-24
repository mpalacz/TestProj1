namespace TestProj1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_add()
        {
            double a = 1.5;
            double b = 2.25;
            double expected = 3.75;
            double actual = MathOperations.addition(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}