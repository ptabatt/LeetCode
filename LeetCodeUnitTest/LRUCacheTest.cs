using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class LRUCacheTest
    {
        [Test]
        public void LRUCache_ExampleTest()
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1); // cache is {1=1}
            lRUCache.Put(2, 2); // cache is {1=1, 2=2}
            Assert.AreEqual(1, lRUCache.Get(1));    // return 1
            lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            Assert.AreEqual(-1, lRUCache.Get(2));    // returns -1 (not found)
            lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            Assert.AreEqual(-1, lRUCache.Get(1));    // return -1 (not found)
            Assert.AreEqual(3, lRUCache.Get(3));    // return 3
            Assert.AreEqual(4, lRUCache.Get(4));    // return 4
        }
    }
}
