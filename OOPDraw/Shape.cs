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
        protected Pen Pen;
        public Shape(int coordX, int coordY, Pen pen)
        {
            CoordX = coordX;
            CoordY = coordY;
            Pen = pen;
        }
        public abstract void Draw(Graphics graphics);
        public abstract void Move(int dx, int dy);
            
    }
}
