using LeetCode;
using NUnit.Framework;
using static LeetCode.MergeTwoSortedListsProblem;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class MergeTwoSortedListsTest
    {
        [Test]
        public void MergeTwoSortedLists_BasicTest()
        {
            var sut = new MergeTwoSortedListsProblem();

            var objLL1 = new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(10))));
            var objLL2 = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(10))));

            var result = sut.MergeTwoLists(objLL1, objLL2);

            Assert.AreEqual(1, result.val);
            result = result.next;
            Assert.AreEqual(2, result.val);
            result = result.next;
            Assert.AreEqual(3, result.val);
            result = result.next;
            Assert.AreEqual(4, result.val);
            result = result.next;
            Assert.AreEqual(6, result.val);
            result = result.next;
            Assert.AreEqual(7, result.val);
            result = result.next;
            Assert.AreEqual(10, result.val);
            result = result.next;
            Assert.AreEqual(10, result.val);
            result = result.next;
            Assert.IsNull(result);

            var objLL3 = new ListNode(5, new ListNode(12, new ListNode(22)));
            var objLL4 = new ListNode(6);

            result = sut.MergeTwoLists(objLL3, objLL4);

            Assert.AreEqual(5, result.val);
            result = result.next;
            Assert.AreEqual(6, result.val);
            result = result.next;
            Assert.AreEqual(12, result.val);
            result = result.next;
            Assert.AreEqual(22, result.val);
            result = result.next;
            Assert.IsNull(result);

            var objLL5 = new ListNode(1);
            var objLL6 = new ListNode(1, new ListNode(55, new ListNode(88)));

            result = sut.MergeTwoLists(objLL5, objLL6);

            Assert.AreEqual(1, result.val);
            result = result.next;
            Assert.AreEqual(1, result.val);
            result = result.next;
            Assert.AreEqual(55, result.val);
            result = result.next;
            Assert.AreEqual(88, result.val);
            result = result.next;
            Assert.IsNull(result);

            ListNode objLL7 = null;
            var objLL8 = new ListNode(20, new ListNode(30));

            result = sut.MergeTwoLists(objLL7, objLL8);

            Assert.AreEqual(20, result.val);
            result = result.next;
            Assert.AreEqual(30, result.val);
            result = result.next;
            Assert.IsNull(result);

            var objLL9 = new ListNode(44);
            ListNode objLL10 = null;

            result = sut.MergeTwoLists(objLL9, objLL10);

            Assert.AreEqual(44, result.val);
            result = result.next;
            Assert.IsNull(result);
        }
    }
}
