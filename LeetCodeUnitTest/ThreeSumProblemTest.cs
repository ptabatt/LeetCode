using LeetCode;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class ThreeSumProblemTest
    {
        [Test]
        public void ThreeSum_Test()
        {
            var sut = new ThreeSumProblem();

            var result = sut.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
            
            Assert.AreEqual(2, result.Count);

            //Since the numbers can appear in any order, this is the way
            //we check that they are not duplicated
            Assert.IsFalse(
                result[1].Contains(result[0][0])
                && result[1].Contains(result[0][1])
                && result[1].Contains(result[0][2]));

            //Since there are only two possible right answers, we will check that
            //they are one or the other
            foreach (List<int> lst in result)
            {
                Assert.IsTrue(
                    (lst.Contains(-1) && lst.Contains(0) && lst.Contains(1)) ^
                    (lst.Contains(-1) && lst.Contains(-1) && lst.Contains(2)));
            }
        }
    }
}
