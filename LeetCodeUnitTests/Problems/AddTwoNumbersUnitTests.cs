namespace LeetCodeUnitTests.Problems
{
    [TestClass]
    public class AddTwoNumbersUnitTests
    {
        [TestMethod]
        public void UnitTest1()
        {
            ListNode l1 = AddTwoNumbers.arrToListNode(new int[] { 2, 4, 3 });
            ListNode l2 = AddTwoNumbers.arrToListNode(new int[] { 5, 6, 4 });

            CollectionAssert.AreEqual(
                new int[] { 7, 0, 8 },
                AddTwoNumbers.listNodeToArr(
                    AddTwoNumbers.addTwoNumbers(
                        l1,
                        l2
                    )
                )
            );
        }

        [TestMethod]
        public void UnitTest2()
        {
            ListNode l1 = AddTwoNumbers.arrToListNode(new int[] { 0 });
            ListNode l2 = AddTwoNumbers.arrToListNode(new int[] { 0 });

            CollectionAssert.AreEqual(
                new int[] {  },
                AddTwoNumbers.listNodeToArr(
                    AddTwoNumbers.addTwoNumbers(
                        l1,
                        l2
                    )
                )
            );
        }

        [TestMethod]
        public void UnitTest3()
        {
            ListNode l1 = AddTwoNumbers.arrToListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            ListNode l2 = AddTwoNumbers.arrToListNode(new int[] { 9, 9, 9, 9 });

            CollectionAssert.AreEqual(
                new int[] { 8, 9, 9, 9, 0, 0, 0, 1 },
                AddTwoNumbers.listNodeToArr(
                    AddTwoNumbers.addTwoNumbers(
                        l1,
                        l2
                    )
                )
            );
        }
    }
}
