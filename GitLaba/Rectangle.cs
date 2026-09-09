using System;
using System.Collections.Generic;
using System.Text;

namespace GitLaba
{
    public class Rectangle
    {
        public Point2D P1 {  get; private set; }
        public Point2D P2 { get; private set; }
        public Point2D P3 { get; private set; }
        public Point2D P4 { get; private set; }
        public Rectangle(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }
    }
}
