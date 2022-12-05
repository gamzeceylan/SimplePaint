using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint.Shapes
{
    public class RectangleShape : Shape
    {
        public RectangleShape(Point locationStaritng, Point locationEnding) : base(locationStaritng, locationEnding) { }
        public RectangleShape(Point locationStaritng, Point locationEnding, Color color) : base(locationStaritng, locationEnding, color) { }

        public override void SetCornerPoints()
        {
            Point[] points ={
                new Point(LocationEnding.X-width , LocationEnding.Y), 
                new Point(LocationEnding.X, LocationEnding.Y ),
                new Point(LocationEnding.X, LocationEnding.Y-height),
                new Point(LocationEnding.X - width, LocationEnding.Y-height)
            };
            this.cornerPoints = points;
        }
        public override string ToString()
        {
            return "RectangleShape";
        }

    }
}
