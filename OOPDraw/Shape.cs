using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace OOPDraw
{
    public abstract class Shape
    {
        protected int CoordX;
        protected int CoordY;
        protected Color Color;
        public Shape(int coordX, int coordY, Color color)
        {
            CoordX = coordX;
            CoordY = coordY;
            Color = color;
        }
        public abstract void Draw(Graphics graphics);
            
    }
}
