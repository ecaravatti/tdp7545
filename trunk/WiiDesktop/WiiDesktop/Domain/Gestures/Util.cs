using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MouseGestures.Common
{
    public static class Util
    {

        /// <summary>
        /// Calculates distance between 2 points
        /// </summary>
        /// <param name="p1">First point</param>
        /// <param name="p2">Second point</param>
        /// <returns>Distance between two points</returns>
        public static double GetDistance(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
