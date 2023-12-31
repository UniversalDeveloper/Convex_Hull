using System;
using System.Collections.Generic;
using System.Text;

namespace ConvexHull
{
 public   class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
