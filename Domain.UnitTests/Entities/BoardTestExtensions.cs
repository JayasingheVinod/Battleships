using Domian.Entities;
using Domian.Entities.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.UnitTests.Entities
{
    internal static class BoardTestExtensions
    {
        internal static string DebuggerDisplayAt(this Board board, string coord)
        {
            return $"At {coord} \n" +
                board
                .Select(y => y.Select(x => x.Symbol))
                .Select(row => string.Join(' ', row.ToArray()))
                .Join('\n');
        }

        internal static Field[][] ToMatrixArray(this Board board)
        {
            return board
                .Select(row => row.ToArray())
                .ToArray();
        }
    }
}
