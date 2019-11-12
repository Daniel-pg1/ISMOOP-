using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Line : Point
    {
        protected int CoordX2;
        protected int CoordY2;
        public Line(int coordX, int coordY, int coordX2, int coordY2, Pen pen)
           : base(coordX, coordY, pen)
        {
            CoordX2 = coordX2;
            CoordY2 = coordY2;
        }
        public override void Draw(Graphics graphics)
        {
            
            graphics.DrawLine(Pen, CoordX, CoordY, CoordX2, CoordY2);
        }
        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);
            CoordX2 += dx;
            CoordY2 += dy;
        }
    }
}
