namespace LeetCodeUnitTests.Problems
{
    [TestClass]
    public class SqrtxUnitTests
    {
        [TestMethod]
        public void Sqrt4UnitTest()
        {
            Assert.AreEqual(2, Sqrtx.sqrtx(4));
        }

        [TestMethod]
        public void Sqrt8UnitTest()
        {
            Assert.AreEqual(2, Sqrtx.sqrtx(8));
        }
    }
}
