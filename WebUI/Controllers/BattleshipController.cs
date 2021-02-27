using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Boards.GenerateEmptyBoard;
using Application.Boards.SaveBoard;
using Application.Common.Commands.ConvertFieldToPoint;
using Application.Common.Commands.GenerateBoardWithShips;
using Application.Ships.GenerateShips;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("api/[controller]")]
    public class BattleshipController : Controller
    {
        private readonly IEmptyBoardGenerator emptyBoardGenerator;
        private readonly IBoardSaver boardSaver;
        private readonly IShipsGenerator shipsGenerator;
        private readonly IFieldToPointConverter fieldToPointConverter;
        private readonly IBoardWithShipsGenerator boardWithShipsGenrator;

        public BattleshipController(
            IEmptyBoardGenerator emptyBoardGenerator,
            IBoardSaver boardSaver,
            IFieldToPointConverter fieldToPointConverter,
            IShipsGenerator shipsGenerator,
            IBoardWithShipsGenerator boardWithShipsGenerator)
        {
            this.emptyBoardGenerator = emptyBoardGenerator;
            this.boardSaver = boardSaver;
            this.fieldToPointConverter = fieldToPointConverter;
            this.shipsGenerator = shipsGenerator;
            this.boardWithShipsGenrator = boardWithShipsGenerator;
        }

        [HttpGet("[action]")]
        public BoardVM Board()
        {
            if (boardSaver.HasBoard())
                return new BoardVM(boardSaver.Get());

            var board = this.GenerateNewBoard();

            return new BoardVM(board);
        }

        [HttpPost("[action]")]
        public void Restart()
        {
            this.GenerateNewBoard();
        }

        [HttpPost("[action]")]
        public void Strike([FromQuery] string field)
        {
            if (!boardSaver.HasBoard())
                return;

            var board = boardSaver.Get();
            var point = fieldToPointConverter.ConvertFrom(field);
            board.Strike(point);

            boardSaver.Set(board);
        }

        private Domian.Entities.Board GenerateNewBoard()
        {
            var board = emptyBoardGenerator.GenerateBoard();
            var ships = shipsGenerator.GenerateShips();
            boardWithShipsGenrator.InsertShips(board, ships);

            boardSaver.Set(board);

            return board;
        }
    }
}