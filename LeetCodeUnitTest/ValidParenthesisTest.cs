using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class ValidParenthesisTest
    {
        [Test]
        public void ValidParenthesis_BasicTest()
        {
            var sut = new ValidParenthesisProblem();

            Assert.IsTrue(sut.IsValid("()"));
            Assert.IsTrue(sut.IsValid("({})"));
            Assert.IsTrue(sut.IsValid("({[]})"));
            Assert.IsTrue(sut.IsValid("({[][][]})(){}"));
            Assert.IsTrue(sut.IsValid("([{[{{{{(((([[[]]]))))}}}}]}])"));
            Assert.IsFalse(sut.IsValid("(}"));
            Assert.IsFalse(sut.IsValid("("));
            Assert.IsFalse(sut.IsValid("[([)])"));
            Assert.IsFalse(sut.IsValid("]]"));
            Assert.IsFalse(sut.IsValid("{([])}[[))]]"));
            Assert.IsFalse(sut.IsValid("([]}"));
            Assert.IsFalse(sut.IsValid("[({[][][]})(){}"));
            Assert.IsFalse(sut.IsValid("({[][][]})(){}]"));
        }
    }
}
