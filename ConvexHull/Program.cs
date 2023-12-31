using System;
using System.Collections.Generic;

namespace ConvexHull
{
    class Program
    {
        static void Main(string[] args)
        {

            // Seznam bodů
            List<Point> points = new List<Point>()
            {

                new Point(0, 0),
                new Point(0, 4),
                new Point(-4, 0),
                new Point(5, 0),
                new Point(0, -6),//start
                new Point(1, 0)

            };

            List<Point> convexHull = ConvexHullScan.FindConvecxHull(points);

            //vstupní seznam n bodů v rovině
            Console.WriteLine("vstupní seznam n bodů v rovině:");
            ListVisual(points);

            // Výpis bodů konvexní obálky
            Console.WriteLine("Výpis bodů konvexní obálky:");
            ListVisual(convexHull);
           

        }

        private static void ListVisual(List<Point> convexHull)
        {
            foreach (Point point in convexHull)
            {
                Console.WriteLine("(" + point.x + ", " + point.y + ")");
            }
        }
    }
}
