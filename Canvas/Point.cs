﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Point
    {
        int x;
        int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX()
        {
            return this.x;
        }
        internal int GetY()
        {
            return this.y;
        }
        internal void SetX(int x)
        {
            if ((x >= 0) && (x <= MyCanvas.MaxWidth))
                this.x = x;
            else
                Console.WriteLine($"x value wrong, not between 0 and {MyCanvas.MaxWidth}");
        }
        internal void SetY(int y)
        {
            if ((y >= 0) && (y <= MyCanvas.MaxWidth))
                this.y = y;
            else
                Console.WriteLine($"y value wrong, not between 0 and {MyCanvas.MaxWidth}");
        }

        public override string ToString()
        {
            return $"x is: {this.x}, y is: {this.y}";
        }
    }
}
