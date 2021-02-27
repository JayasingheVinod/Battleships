using Application.Boards.SaveBoard;
using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Boards.SaveBoard
{
    public class BoardSaver : IBoardSaver
    {
        private Board board = null;

        public bool HasBoard()
        {
            return board != null;
        }

        public Board Get()
        {
            if (!HasBoard())
                throw new MissingBoardException();

            return board;
        }

        public void Set(Board board)
        {
            this.board = board; 
        }
    }
}
