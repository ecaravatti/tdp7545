using System;
using System.Collections.Generic;
using System.Text;

namespace WiiDesktop.Common
{
    public class Point
    {
        private float x;
        private float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }
    }
}
