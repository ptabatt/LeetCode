using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        public void BinarySearch_BasicTest()
        {
            var sut = new BinarySearchProblem();

            Assert.AreEqual(4, sut.Search(new[] { -1, 0, 3, 5, 9, 12 }, 9));
            Assert.AreEqual(-1, sut.Search(new[] { -1, 0, 3, 5, 9, 12 }, 2));
        }
    }
}
