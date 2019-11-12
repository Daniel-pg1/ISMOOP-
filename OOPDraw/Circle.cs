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
        public Circle(int coordX, int coordY, int radius1, Pen pen)
            : base(coordX, coordY, pen)
        {
            Radius1 = radius1;
        }
        public override void Draw(Graphics graphics)
        {

            graphics.DrawEllipse(Pen, CoordX - Radius1/2, CoordY-Radius1/2, Radius1, Radius1);
        }
        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);
        }
    }
}
