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
        public Ellipse(int coordX, int coordY, int radius1, int radius2, Color color)
          : base(coordX, coordY, radius1, color)
        {
            Radius2 = radius2;
        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, 1);
            graphics.DrawEllipse(pen, CoordX, CoordY, Radius1, Radius2);
        }
    }
}
