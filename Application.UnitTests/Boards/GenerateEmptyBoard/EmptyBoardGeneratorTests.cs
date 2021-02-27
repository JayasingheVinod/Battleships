using Application.Boards.GenerateEmptyBoard;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UnitTests.Boards.GenerateEmptyBoard
{
    [Category("Unit")]
    public class EmptyBoardGeneratorTests
    {
        private EmptyBoardGenerator emptyBoardGenerator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.emptyBoardGenerator = new EmptyBoardGenerator();
        }

        [Test]
        public void It_can_generate_board_with_correct_dimensions()
        {
            var board = emptyBoardGenerator.GenerateBoard();

            Assert.That(board.Limits.X, Is.EqualTo(9));
            Assert.That(board.Limits.Y, Is.EqualTo(9));

            Assert.That(board, Has.Exactly(10).Items);
            Assert.That(board, Has.All.Exactly(10).Items);
        }
    }
}
