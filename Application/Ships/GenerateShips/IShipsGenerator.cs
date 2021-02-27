using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Ships.GenerateShips
{
    public interface IShipsGenerator
    {
        IEnumerable<Ship> GenerateShips();
    }
}
