using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Commands.GenerateBoardWithShips
{
    public class BoardWithShipsGenerator : IBoardWithShipsGenerator
    {

        public Board InsertShips(Board board, IEnumerable<Ship> ships)
        {
            foreach (var ship in ships)
            {
                while (true)
                {
                    var coordinates = this.GeneratePointsForInsertShip(board, ship);

                    if (!board.CanInsert(coordinates))
                        continue;

                    board.InsertShip(coordinates);
                    break;
                }
            }

            return board;
        }

        public Coordinates GeneratePointsForInsertShip(Board board, Ship ship)
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());

            var direction = rand.Next(0, 2) == 1;
            var startX = rand.Next(0, direction ? board.Limits.X : board.Limits.X - ship.Length);
            var startY = rand.Next(0, direction ? board.Limits.Y - ship.Length : board.Limits.Y);

            return new Coordinates(
              new Point(startX, startY),
              new Point(
                direction ? startX : startX + ship.Length - 1,
                direction ? startY + ship.Length - 1 : startY
              ));
        }
    }
}
