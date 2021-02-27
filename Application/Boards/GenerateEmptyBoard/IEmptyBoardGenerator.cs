using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Boards.GenerateEmptyBoard
{
    public interface IEmptyBoardGenerator
    {
        Board GenerateBoard();
    }
}
