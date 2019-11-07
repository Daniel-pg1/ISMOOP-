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
        public Rectangle(int coordX, int coordY, int coordX2, int coordY2, Color color)
           : base(coordX, coordY,  coordX2, coordY2, color)
        {

        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 2);
            graphics.DrawRectangle(pen, CoordX, CoordY, CoordX2, CoordY2 );
        }
    }
}
