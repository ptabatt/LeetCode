using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class LinkedListCycleIITest
    {
        [Test]
        public void LinkedListCycleIIPositiveTest()
        {
            var objSut = new LinkedListCycleIIProblem();

            var ll = new ListNode
            {
                val = 3
            };

            var cycleNodeStart = new ListNode
            {
                val = 2
            };

            var cycleNodeMiddle = new ListNode
            {
                val = 0            };

            var cycleNodeEnd = new ListNode
            {
                val = -4
            };

            ll.next = cycleNodeStart;
            cycleNodeStart.next = cycleNodeMiddle;
            cycleNodeMiddle.next = cycleNodeEnd;
            cycleNodeEnd.next = cycleNodeStart;

            Assert.AreEqual(cycleNodeStart, objSut.DetectCycle(ll));
        }

        [Test]
        public void LinkedListCycleIINegativeTest()
        {
            var objSut = new LinkedListCycleIIProblem();

            var ll = new ListNode
            {
                val = 3
            };

            Assert.AreEqual(null, objSut.DetectCycle(ll));
        }
    }
}
