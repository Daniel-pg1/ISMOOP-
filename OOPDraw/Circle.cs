using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Circle : Point
    {
        protected int Radius1;
        public Circle(int coordX, int coordY, int radius1, Color color)
            : base(coordX, coordY, color)
        {
            Radius1 = radius1;
        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 2);
            graphics.DrawEllipse(pen, CoordX, CoordY, Radius1, Radius1);
        }
    }
}
