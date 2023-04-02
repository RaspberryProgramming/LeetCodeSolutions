namespace LeetCodeUnitTests.Problems
{
    [TestClass]
    public class TwoSumUnitTests
    {

        [TestMethod]
        public void UnitTest1()
        {
            CollectionAssert.Equals(
                new int[] { 0, 1 },
                TwoSum.twoSum(new int[] { 2, 7, 11, 15 }, 9)
            );
        }

        [TestMethod]
        public void UnitTest2()
        {
            CollectionAssert.Equals(
                new int[] { 1, 2 },
                TwoSum.twoSum(new int[] { 3, 2, 4 }, 6)
            );
        }

        [TestMethod]
        public void UnitTest3()
        {
            CollectionAssert.Equals(
                new int[] { 0, 1 },
                TwoSum.twoSum(new int[] { 3, 3 }, 6)
            );
        }
    }
}