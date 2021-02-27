using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Ships.GenerateShips
{
    public class ShipsGenerator : IShipsGenerator
    {
        public IEnumerable<Ship> GenerateShips()
        {
            yield return new Battleship();
            yield return new Destroyer();
            yield return new Destroyer();
        }
    }
}
