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
        public Point(int coordX, int coordY, Color color) 
            : base(coordX, coordY, color)
        {

        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 2);
            graphics.DrawEllipse(pen, CoordX - 1, CoordY - 1, 2, 2);
        }
    }
}
