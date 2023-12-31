using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConvexHull
{
    public class ConvexHullScan
    {

        // Metoda pro nalezení nejlevějšího spodního bodu (bod s nejmenšími souřadnicemi x a y)
        public static Point FindMinBottomPoint(List<Point> points)
        {

            int index = 0;
            for (int i = 1; i < points.Count; i++)
            {
                if (points[i].y < points[index].y || (points[i].y == points[index].y && points[i].x < points[index].x))
                {
                    index = i;

                }
            }
            return new Point(points[index].x, points[index].y);
            

        }

        //Metoda pro výpočet determinantu tří bodů
                private static int ComputeClockwise(Point p1, Point p2, Point p3)
        {
            float area = (p2.x - p1.x) * (p3.y - p1.y) - (p3.x - p1.x) * (p2.y - p1.y);
            if (area < 0) return -1;//clockwise
            if (area > 0) return 1;// countClockwise

            return 0;// colliner
        }


        //Metoda pro výpočet obalovou křivku
        public static List<Point> FindConvecxHull(List<Point> points) {

            List<Point> ConvecxHull = new List<Point>();
            Point startPoint = FindMinBottomPoint(points);
            ConvecxHull.Add(startPoint);
            Point prevVertex = startPoint;
           

            while(true)
            {
                Point candidate = null;
                foreach (var point in points)
                {
                    if (point == prevVertex) continue;
                    if (candidate == null)
                    {
                        candidate = point;
                        continue;

                    }
                    var countClockWis = ComputeClockwise(prevVertex, candidate, point);
                    
                    if (countClockWis < 0)
                    {
                        candidate = point;
                    }
                }
                

               if (candidate.x == startPoint.x&& candidate.y == startPoint.y)
                {
                    break;
                    
                }

                ConvecxHull.Add(candidate);
                prevVertex = candidate;

            } 
            return ConvecxHull;
        }


    }
}