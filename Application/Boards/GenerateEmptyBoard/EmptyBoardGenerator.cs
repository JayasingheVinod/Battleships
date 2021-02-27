using Application.Common.Extensions;
using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Boards.GenerateEmptyBoard
{
    public class EmptyBoardGenerator : IEmptyBoardGenerator
    {
        public Point Limits;

        public Board GenerateBoard()
        {
            return new Board(9, 9);
        }
       
    }
}
