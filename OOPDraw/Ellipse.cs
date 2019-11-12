using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOPDraw
{
    public class Ellipse : Circle
    {
        protected int Radius2;
        public Ellipse(int coordX, int coordY, int radius1, int radius2, Pen pen)
          : base(coordX, coordY, radius1, pen)
        {
            Radius2 = radius2;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pen, CoordX - Radius1/2, CoordY-Radius2/2, Radius1, Radius2);
        }
        public override void Move(int dx, int dy)
        {
            base.Move(dx, dy);
        }
    }
}
