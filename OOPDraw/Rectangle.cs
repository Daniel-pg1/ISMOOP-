using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPDraw
{
    public class Rectangle : Line
    {
        public Rectangle(int coordX, int coordY, int coordX2, int coordY2, Pen pen)
           : base(coordX, coordY,  coordX2, coordY2, pen)
        {

        }
        public override void Draw(Graphics graphics)
        {
             graphics.DrawRectangle(Pen, CoordX - CoordX2/2, CoordY - CoordY2/2, CoordX2, CoordY2 );
        }
        public override void Move(int dx, int dy)
        {
            CoordX -= -dx;
            CoordY -= -dy;
        }
    }
}
