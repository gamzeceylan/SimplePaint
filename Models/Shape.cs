using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint.Shapes
{
    
    public abstract class Shape
    {

        protected Point[] cornerPoints; // içeride bunula işlem yapıcaz
        protected int width;
        protected int height;
        public Point LocationStarting { get; set; }
        public Point LocationEnding { get; set; }
        public int X { get => this.LocationStarting.X; }
        public int Y { get => this.LocationStarting.Y; }
        public int Width { get => this.width; }
        public int Height { get => this.height; }
        public Point[] CornerPoints { get => this.cornerPoints; } // içeridekini verecek ama bi rşey değiştiremeyecek
        public SolidBrush BrushColor { get; set; } // sonra değiştirilecek
       

        public Shape(Point locationStaritng, Point locationEnding)
        {
            this.LocationStarting = locationStaritng;
            this.LocationEnding = locationEnding;
            this.BrushColor = new SolidBrush(Color.Black);
            SetHeightAndWidth();
        }
        public Shape(Point locationStaritng, Point locationEnding, Color color)
        {
            this.LocationStarting = locationStaritng;
            this.LocationEnding = locationEnding;
            this.BrushColor = new SolidBrush(color);
            SetHeightAndWidth();
        }
        private void SetHeightAndWidth() 
        {
            this.width = (LocationEnding.X - LocationStarting.X); 
            this.height = (LocationEnding.Y - LocationStarting.Y);
        }

        public abstract void SetCornerPoints(); 

    }
}
