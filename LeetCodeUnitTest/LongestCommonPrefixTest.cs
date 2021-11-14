using NUnit.Framework;
using LeetCode;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class LongestCommonPrefixTest
    {
        [Test]
        public void LongestCommonPrefixBetweenTwoStrings_BasicTest()
        {
            var sut = new LongestCommonPrefixProblem();

            Assert.AreEqual("mr", sut.LongestCommonPrefixBetweenTwoStrings("mr t", "mrs s"));
            Assert.AreEqual("zzabc", sut.LongestCommonPrefixBetweenTwoStrings("zzabc", "zzabcd"));
            Assert.AreEqual("zzabc", sut.LongestCommonPrefixBetweenTwoStrings("zzabcd", "zzabc"));
            Assert.AreEqual("zz", sut.LongestCommonPrefixBetweenTwoStrings("zz abc", "zzzabc"));
            Assert.AreEqual("data", sut.LongestCommonPrefixBetweenTwoStrings("database", "datacenter"));
            Assert.AreEqual("", sut.LongestCommonPrefixBetweenTwoStrings("fu", "abc"));
            Assert.AreEqual("", sut.LongestCommonPrefixBetweenTwoStrings("bat", "cat"));
        }

        [Test]
        public void LongestCommonPrefix_BasicTest()
        {
            var sut = new LongestCommonPrefixProblem();

            Assert.AreEqual("a", sut.LongestCommonPrefix(new[] { "a" }));

            Assert.AreEqual("fl", sut.LongestCommonPrefix(
                new[] { "flower", "flow", "flight" }));

            Assert.AreEqual("", sut.LongestCommonPrefix(
                new[] { "dog", "racecar", "car" }));

            Assert.AreEqual("ring", sut.LongestCommonPrefix(
                new string[]
                {
                     "ring-bearer"
                    ,"ringleader"
                    ,"ringworm"
                }));

            Assert.AreEqual("string", sut.LongestCommonPrefix(
                new string[]
                {
                     "string"
                    ,"stringi"
                    ,"stringiness"
                }));

            Assert.AreEqual("", sut.LongestCommonPrefix(
                 new string[]
                 {
                     "ring-bearer"
                    ,"lord of the rings"
                    ,"ringleader"
                    ,"ringworm"
                 }));

            Assert.AreEqual("", sut.LongestCommonPrefix(
                new string[]
                {
                     "goodbye"
                    ,"bye"
                    ,"bye bye"
                    ,"byebye"
                    ,"bye-bye"
                }));

            Assert.AreEqual("", sut.LongestCommonPrefix(
                new string[]
                {
                     "bye"
                    ,"bye bye"
                    ,"byebye"
                    ,"bye-bye"
                    ,"goodbye"
                }));
            
            Assert.AreEqual("", sut.LongestCommonPrefix(
                new string[]
                {
                     "string"
                    ,"const"
                    ,"struct"
                    ,"zoo"
                }));
        }
    }
}
