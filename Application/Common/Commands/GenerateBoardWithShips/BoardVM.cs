using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Common.Commands.GenerateBoardWithShips
{
    public class BoardVM
    {
        public BoardVM (Board board)
        {
            Board = board
                .Select(row => row
                    .Select(i => i.Symbol));

            HasWon = board.HasWon();
        }

        public IEnumerable<IEnumerable<char>> Board { get; set; }

        public bool HasWon { get; set; }
    }
}
