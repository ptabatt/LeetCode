using LeetCode;
using NUnit.Framework;

namespace LeetCodeUnitTest
{
    [TestFixture]
    public class IsValidSudokuTest
    {
        [Test]
        public void IsValidSudokuPositiveTest()
        {
            var board = new char[][]
                {
                    new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };

            var sut = new IsValidSudokuProblem();

            Assert.IsTrue(sut.IsValidSudoku(board));
        }

        [Test]
        public void IsValidSudokuNegativeTest()
        {
            var board = new char[][]
                {
                    new[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new[] { '8', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new[] { '.', '6', '.', '.', '.', '.', '2', '8', '.'},
                    new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };

            var sut = new IsValidSudokuProblem();

            Assert.IsFalse(sut.IsValidSudoku(board));
        }

        [Test]
        public void IsValidSudokuNegativeTest2()
        {
            var board = new char[][]
                {
                    new[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                    new[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                    new[] { '.', '.', '.', '.', '6', '.', '.', '.', '3'},
                    new[] { '4', '.', '.', '8', '.', '3', '.', '.', '1'},
                    new[] { '7', '.', '.', '.', '2', '.', '.', '.', '6'},
                    new[] { '.', '6', '.', '.', '.', '.', '9', '8', '.'},
                    new[] { '.', '.', '.', '4', '1', '9', '.', '.', '5'},
                    new[] { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
                };

            var sut = new IsValidSudokuProblem();

            Assert.IsFalse(sut.IsValidSudoku(board));
        }
    }
}
