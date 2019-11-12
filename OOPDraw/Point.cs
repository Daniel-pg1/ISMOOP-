using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Point : Shape
    {
        public Point(int coordX, int coordY, Pen pen) 
            : base(coordX, coordY, pen)
        {

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, CoordX - 1, CoordY - 1, 2, 2);
        }
        public override void Move(int dx, int dy)
        {
            CoordX += dx;
            CoordY += dy;
        }
    }
}
