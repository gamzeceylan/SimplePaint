using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint.Shapes
{
    public class TriangleShape : Shape
    {
        public TriangleShape(Point locationStaritng, Point locationEnding) : base(locationStaritng, locationEnding) { }
        public TriangleShape(Point locationStaritng, Point locationEnding, Color color) : base(locationStaritng, locationEnding, color) { }

        public override void SetCornerPoints()
        {
            Point[] points ={
                  new Point(LocationStarting.X , LocationStarting.Y+ height), // this.XStartPosition, this.YStartPosition
                  new Point(LocationEnding.X, LocationEnding.Y),
                  new Point(LocationStarting.X + width/2, LocationStarting.Y),
            };
            this.cornerPoints = points;
        }
        public override string ToString()
        {
            return "TriangleShape";
        }
    }
}
