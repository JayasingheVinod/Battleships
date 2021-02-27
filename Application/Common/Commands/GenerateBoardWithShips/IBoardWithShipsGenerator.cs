using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Commands.GenerateBoardWithShips
{
    public interface IBoardWithShipsGenerator
    {
        Board InsertShips(Board board, IEnumerable<Ship> ships);
        Coordinates GeneratePointsForInsertShip(Board board, Ship ship);
    }
}
