﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domian.Entities.Common.Extensions
{
    internal static class CoordinatesExtensions
    {
        internal static bool IsInLimits(this Coordinates coord, Point limits)
        {
            return coord.Start.X.IsBetweenInclusive(0, limits.X) &&
              coord.Start.Y.IsBetweenInclusive(0, limits.Y) &&
              coord.End.X.IsBetweenInclusive(0, limits.X) &&
              coord.End.Y.IsBetweenInclusive(0, limits.Y);
        }

        private static bool IsBetweenInclusive(this int value, int start, int end)
        {
            return start <= value && value <= end;
        }
    }
}
