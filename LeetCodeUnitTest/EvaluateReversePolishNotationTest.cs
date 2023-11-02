using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class EvaluateReversePolishNotationTest
    {
        [Test]
        public void EvaluateReversePolishNotationTest1()
        {
            var sut = new EvaluateReversePolishNotationProblem();

            var tokens = new[] { "2", "1", "+", "3", "*" };
            Assert.AreEqual(9, sut.EvalRPN(tokens));
        }

        [Test]
        public void EvaluateReversePolishNotationTest2()
        {
            var sut = new EvaluateReversePolishNotationProblem();

            var tokens = new[] { "4", "13", "5", "/", "+" };
            Assert.AreEqual(6, sut.EvalRPN(tokens));
        }

        [Test]
        public void EvaluateReversePolishNotationTest3()
        {
            var sut = new EvaluateReversePolishNotationProblem();

            var tokens = new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            Assert.AreEqual(22, sut.EvalRPN(tokens));
        }

        [Test]
        public void EvaluateReversePolishNotationEdgeCase1()
        {
            var sut = new EvaluateReversePolishNotationProblem();

            var tokens = new[] { "10" };
            Assert.AreEqual(10, sut.EvalRPN(tokens));
        }

        [Test]
        public void EvaluateReversePolishNotationEdgeCase2()
        {
            var sut = new EvaluateReversePolishNotationProblem();

            var tokens = new[] { "3", "11", "+", "5", "-" };
            Assert.AreEqual(9, sut.EvalRPN(tokens));
        }
    }
}
