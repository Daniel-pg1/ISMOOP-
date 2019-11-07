using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPDraw;
namespace OOPDrawWindowsForm
{
    public partial class Form1 : Form
    {
        protected Shape[] shapes;
        public Form1()
        {
           InitializeComponent();

            
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            shapes = new Shape[trackBarElNumber.Value];
            for (int i = 0; i < shapes.Length; i++)
            {
                Color Color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                int elements = rnd.Next(0, 5);
                switch (elements)
                {
                    case 0:
                        shapes[i] = new OOPDraw.Point(rnd.Next(0, pictureBoxDraw.Width),
                                                      rnd.Next(0, pictureBoxDraw.Height),  Color);
                        break;
                    case 1:
                        shapes[i] = new Ellipse(rnd.Next(5, pictureBoxDraw.Width / 2), 
                                                rnd.Next(5, pictureBoxDraw.Height / 2), 
                                                rnd.Next(5, pictureBoxDraw.Width / 8), 
                                                rnd.Next(5, pictureBoxDraw.Height / 8), Color);
                        break;
                    case 2:
                        shapes[i] = new Line(rnd.Next(5, pictureBoxDraw.Width), 
                                             rnd.Next(5, pictureBoxDraw.Height), 
                                             rnd.Next(5, pictureBoxDraw.Width), 
                                             rnd.Next(5, pictureBoxDraw.Height), Color);
                        break;
                    case 3:
                        shapes[i] = new Circle(rnd.Next(5, pictureBoxDraw.Width / 2), 
                                               rnd.Next(5, pictureBoxDraw.Height / 2), 
                                               rnd.Next(5,pictureBoxDraw.Width / 10), Color);
                        break;
                    case 4:
                        shapes[i] = new OOPDraw.Rectangle(rnd.Next(5, pictureBoxDraw.Width / 2), 
                                                          rnd.Next(5, pictureBoxDraw.Height / 2), 
                                                          rnd.Next(5, pictureBoxDraw.Width / 2), 
                                                          rnd.Next(5, pictureBoxDraw.Height / 2), Color);
                        break;
                    default:
                        break;
                }
            }
            
            
            pictureBoxDraw.Invalidate();
           
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {

            Graphics graph = pictureBoxDraw.CreateGraphics();
            Brush brush = new SolidBrush(Color.White);
            graph.FillRectangle(brush, 0, 0, pictureBoxDraw.Width, pictureBoxDraw.Height);
            
            
        }

        private void pictureBoxDraw_Paint_1(object sender, PaintEventArgs e)
        {
           
            if (shapes != null)
            {
                for (int i = 0; i < shapes.Length; i++)
                {
                    shapes[i].Draw(e.Graphics);
                }
            }
        }
    }
}
