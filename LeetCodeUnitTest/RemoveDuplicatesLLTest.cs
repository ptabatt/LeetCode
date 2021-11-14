using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class RemoveDuplicatesLLTest
    {
        [Test]
        public void RemoveDuplicatesLL_BasicTest()
        {
            var sut = new RemoveDuplicatesLLProblem();

            var lnInput = new ListNode
            {
                val = 3,
                next = new ListNode
                {
                    val = 4,
                    next = new ListNode
                    {
                        val = 4,
                        next = new ListNode
                        {
                            val = 5,
                            next = new ListNode
                            {
                                val = 5,
                                next = new ListNode
                                {
                                    val = 5,
                                    next = null
                                }
                            }
                        }
                    }
                }
            };

            var lnResult = sut.DeleteDuplicates(lnInput);

            Assert.AreEqual(3, lnResult.val);
            Assert.AreEqual(4, lnResult.next.val);
            Assert.AreEqual(5, lnResult.next.next.val);
            Assert.AreEqual(null, lnResult.next.next.next);
        }
    }
}
