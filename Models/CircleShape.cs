using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint.Shapes
{
    public class CircleShape : Shape
    {
        public CircleShape(Point locationStaritng, Point locationEnding) : base(locationStaritng, locationEnding) { }
        public CircleShape(Point locationStaritng, Point locationEnding, Color color) : base(locationStaritng, locationEnding, color) { }

        public override void SetCornerPoints()
        {
            Point[] points ={
                  new Point(LocationStarting.X, LocationStarting.Y)
            };
            this.cornerPoints = points;
        }
        public override string ToString()
        {
            return "CircleShape";
        }
    }
    
}
