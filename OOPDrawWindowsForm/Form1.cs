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
        protected List<Shape> shapes;
        public Form1()
        {
           InitializeComponent();
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            shapes = new List<Shape>();
            for (int i = 0; i < trackBarElNumber.Value; i++)
            {
                Pen pen = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(0,5)));
                int elements = rnd.Next(0, 5);
                switch (elements)
                {
                    case 0:
                        shapes.Add( new OOPDraw.Point(rnd.Next(0, pictureBoxDraw.Width),
                                                      rnd.Next(0, pictureBoxDraw.Height), pen));
                        break;
                    case 1:
                        shapes.Add( new Ellipse(rnd.Next(5, pictureBoxDraw.Width), 
                                                rnd.Next(5, pictureBoxDraw.Height), 
                                                rnd.Next(5, pictureBoxDraw.Width/10), 
                                                rnd.Next(5, pictureBoxDraw.Height/10), pen));
                        break;
                    case 2:
                        shapes.Add( new Line(rnd.Next(5, pictureBoxDraw.Width), 
                                             rnd.Next(5, pictureBoxDraw.Height), 
                                             rnd.Next(5, pictureBoxDraw.Width), 
                                             rnd.Next(5, pictureBoxDraw.Height), pen));
                        break;
                    case 3:
                        shapes.Add(new Circle(rnd.Next(5, pictureBoxDraw.Width), 
                                               rnd.Next(5, pictureBoxDraw.Height), 
                                               rnd.Next(5,pictureBoxDraw.Width/10), pen));
                        break;
                    case 4:
                        shapes.Add( new OOPDraw.Rectangle(rnd.Next(5, pictureBoxDraw.Width), 
                                                          rnd.Next(5, pictureBoxDraw.Height), 
                                                          rnd.Next(5, pictureBoxDraw.Width/2), 
                                                          rnd.Next(5, pictureBoxDraw.Height/2), pen));
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
            shapes = new List<Shape>();
            
        }

        private void pictureBoxDraw_Paint_1(object sender, PaintEventArgs e)
        {
           
            if (shapes != null)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes[i].Draw(e.Graphics);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int num = (int)numericUpDownShapes.Value;
            if (num < shapes.Count && num >= 0)
            {
                shapes.RemoveAt(num);    
            }
            pictureBoxDraw.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            if (shapes == null)
                shapes = new List<Shape>();         
                Random rnd = new Random();  
              Pen pen = new Pen(colorDialog1.Color, rnd.Next(0, 5));
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        shapes.Add(new OOPDraw.Point(rnd.Next(0, pictureBoxDraw.Width),
                                                      rnd.Next(0, pictureBoxDraw.Height), pen));
                        break;
                    case 1:
                        shapes.Add(new Ellipse(rnd.Next(5, pictureBoxDraw.Width),
                                                rnd.Next(5, pictureBoxDraw.Height),
                                                rnd.Next(5, pictureBoxDraw.Width/10),
                                                rnd.Next(5, pictureBoxDraw.Height/10), pen));
                        break;
                    case 2:
                        shapes.Add(new Line(rnd.Next(5, pictureBoxDraw.Width),
                                             rnd.Next(5, pictureBoxDraw.Height),
                                             rnd.Next(5, pictureBoxDraw.Width),
                                             rnd.Next(5, pictureBoxDraw.Height), pen));
                        break;
                    case 3:
                        shapes.Add(new Circle(rnd.Next(5, pictureBoxDraw.Width),
                                               rnd.Next(5, pictureBoxDraw.Height),
                                               rnd.Next(5, pictureBoxDraw.Width/10), pen));
                        break;
                    case 4:
                        shapes.Add(new OOPDraw.Rectangle(rnd.Next(5, pictureBoxDraw.Width),
                                                          rnd.Next(5, pictureBoxDraw.Height),
                                                          rnd.Next(5, pictureBoxDraw.Width /5),
                                                          rnd.Next(5, pictureBoxDraw.Height/5), pen));
                        break;
                    default:
                        break;
                }
                pictureBoxDraw.Refresh();
            
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            int dx = (int)numericUpDownX.Value;
            int dy = (int)numericUpDownY.Value;
            int num = (int)numericUpDownShapes.Value;
            if (num < shapes.Count && num >= 0) 
            {
                shapes[num].Move(dx, dy);
            }
            pictureBoxDraw.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBarElNumber_Scroll(object sender, EventArgs e)
        {

        }

        private void numericUpDownShapes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {

        }
        protected int X;
        protected int Y;
        private void pictureBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
        private void pictureBoxDraw_MouseUp(object sender, MouseEventArgs e)
        {
            int X2 = e.X;
            int Y2 = e.Y;
            if (shapes == null)     
                shapes = new List<Shape>();
            Random rnd = new Random();
            Pen pen = new Pen(colorDialog1.Color, rnd.Next(5));
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    shapes.Add(new OOPDraw.Point(X2, Y2, pen));
                    break;
                case 1:
                    shapes.Add(new Ellipse(X2,  Y2, rnd.Next(5, pictureBoxDraw.Width / 10),
                                            rnd.Next(5, pictureBoxDraw.Height / 10), pen));
                    break;
                case 2:
                    shapes.Add(new Line(X, Y, X2, Y2, pen));
                    break;
                case 3:
                    shapes.Add(new Circle(X, Y,
                                           rnd.Next(5, pictureBoxDraw.Width / 10), pen));
                    break;
                case 4:
                    shapes.Add(new OOPDraw.Rectangle(X2, Y2, rnd.Next(5, pictureBoxDraw.Width / 2), rnd.Next(5, pictureBoxDraw.Height / 2), pen));
                    break;
                default:
                    break;
            }
            pictureBoxDraw.Refresh();

        }

        private void pictureBoxDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (comboBox1.SelectedIndex == 2)
                {
                    Random rnd = new Random();
                    pictureBoxDraw.Refresh();
                    Graphics graphics = pictureBoxDraw.CreateGraphics();
                    graphics.DrawLine(new Pen(colorDialog1.Color, 2), X, Y, e.X, e.Y);
                }
            }
        }
    }
}
