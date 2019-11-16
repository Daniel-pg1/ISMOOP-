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
                Pen pen = new Pen(Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)), rnd.Next(5));
                int elements = rnd.Next(0, 5);
                switch (elements)
                {
                    case 0:
                        shapes.Add( new OOPDraw.Point(rnd.Next(0, pictureBoxDraw.Width),
                                                      rnd.Next(0, pictureBoxDraw.Height), pen));
                        break;
                    case 1:
                        shapes.Add( new Ellipse(rnd.Next(5, pictureBoxDraw.Width/2), 
                                                rnd.Next(5, pictureBoxDraw.Height/2), 
                                                rnd.Next(5, pictureBoxDraw.Width/10), 
                                                rnd.Next(5, pictureBoxDraw.Height/10), pen));
                        break;
                    case 2:
                        shapes.Add( new Line(rnd.Next(5, pictureBoxDraw.Width/2), 
                                             rnd.Next(5, pictureBoxDraw.Height/2 ), 
                                             rnd.Next(5, pictureBoxDraw.Width/2 ), 
                                             rnd.Next(5, pictureBoxDraw.Height/2 ), pen));
                        break;
                    case 3:
                        shapes.Add(new Circle(rnd.Next(5, pictureBoxDraw.Width/2), 
                                               rnd.Next(5, pictureBoxDraw.Height/2), 
                                               rnd.Next(5,pictureBoxDraw.Width/10), pen));
                        break;
                    case 4:
                        shapes.Add( new OOPDraw.Rectangle(rnd.Next(5, pictureBoxDraw.Width/2 ), 
                                                          rnd.Next(5, pictureBoxDraw.Height /2), 
                                                          rnd.Next(5, pictureBoxDraw.Width/2 ), 
                                                          rnd.Next(5, pictureBoxDraw.Height /2), pen));
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            if (shapes == null)
                shapes = new List<Shape>();         
                Random rnd = new Random();
            int width = int.Parse(textBoxWidth.Text);
            if (width <= 0)
                MessageBox.Show("Помилка вводу ширини! Ширина фiгури не може бути 0 або менше!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Pen pen = new Pen(colorDialog1.Color, width);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        shapes.Add(new OOPDraw.Point(rnd.Next(0, pictureBoxDraw.Width),
                                                      rnd.Next(0, pictureBoxDraw.Height), pen));
                        break;
                    case 1:
                        shapes.Add(new Ellipse(rnd.Next(5, pictureBoxDraw.Width/2),
                                                rnd.Next(5, pictureBoxDraw.Height/2),
                                                rnd.Next(5, pictureBoxDraw.Width/10),
                                                rnd.Next(5, pictureBoxDraw.Height/10), pen));
                        break;
                    case 2:
                        shapes.Add(new Line(rnd.Next(5, pictureBoxDraw.Width/2),
                                             rnd.Next(5, pictureBoxDraw.Height/2),
                                             rnd.Next(5, pictureBoxDraw.Width/2),
                                             rnd.Next(5, pictureBoxDraw.Height/2), pen));
                        break;
                    case 3:
                        shapes.Add(new Circle(rnd.Next(5, pictureBoxDraw.Width/2),
                                               rnd.Next(5, pictureBoxDraw.Height/2),
                                               rnd.Next(5, pictureBoxDraw.Width/10), pen));
                        break;
                    case 4:
                        shapes.Add(new OOPDraw.Rectangle(rnd.Next(5, pictureBoxDraw.Width/2),
                                                          rnd.Next(5, pictureBoxDraw.Height/2),
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
        protected int X;
        protected int Y;
        protected int X2;

        protected int Y2;
        private void pictureBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }
        private void pictureBoxDraw_MouseUp(object sender, MouseEventArgs e)
        {
             X2 = e.X;
             Y2 = e.Y;
            if (shapes == null)     
                shapes = new List<Shape>();
            Random rnd = new Random();
            int width = int.Parse(textBoxWidth.Text);
            if (width <= 0)
                MessageBox.Show("Помилка вводу ширини! Ширина фiгури не може бути 0 або менше!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Pen pen = new Pen(colorDialog1.Color, width);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    shapes.Add(new OOPDraw.Point(X2, Y2, pen));
                    break;
                case 1:
                    shapes.Add(new Ellipse(X,  Y, X2 - X, Y2 - Y, pen));
                    break;
                case 2:
                 shapes.Add(new Line(X, Y, X2, Y2, pen));
                    break;
                case 3:
                    shapes.Add(new Circle(X, Y, X2 - X, pen));
                    break;
                case 4:
                    if (e.X <= X && e.Y <= Y)
                        shapes.Add(new OOPDraw.Rectangle(e.X, e.Y, X - e.X, Y - e.Y, pen));
                    else if(e.X <= X && e.Y >= Y)
                        shapes.Add(new OOPDraw.Rectangle(e.X, Y, X - e.X, e.Y - Y, pen));
                    else if (e.X >= X && e.Y <= Y)
                        shapes.Add(new OOPDraw.Rectangle(X, e.Y, e.X - X, Y - e.Y, pen));
                    else
                        shapes.Add(new OOPDraw.Rectangle(X, Y, X2 - X, Y2 - Y, pen));
                    break;
                default:
                    break;
            }
            pictureBoxDraw.Refresh();

        }

        private void pictureBoxDraw_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            Graphics graphics = pictureBoxDraw.CreateGraphics();
            int width = int.Parse(textBoxWidth.Text);
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(colorDialog1.Color, width);
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        pictureBoxDraw.Refresh();
                        graphics.DrawEllipse(pen, X, Y, e.X - X, e.Y-Y);
                        break;
                    case 2:
                        pictureBoxDraw.Refresh(); 
                       graphics.DrawLine(pen, X, Y, e.X, e.Y);
                        break;
                    case 3:
                        pictureBoxDraw.Refresh();
                        graphics.DrawEllipse(pen, X, Y, e.X - X, e.X - X);
                        break;
                    case 4:
                        pictureBoxDraw.Refresh();
                        if (e.X <= X && e.Y <= Y)
                        graphics.DrawRectangle(pen, e.X, e.Y, X - e.X, Y - e.Y);
                        else if (e.X <= X && e.Y >= Y)
                        graphics.DrawRectangle(pen, e.X, Y, X - e.X, e.Y - Y);
                        else if (e.X >= X && e.Y <= Y)
                        graphics.DrawRectangle(pen, X, e.Y, e.X - X, Y - e.Y);
                        else
                        graphics.DrawRectangle(pen, X, Y, e.X - X, e.Y - Y);
                        break;
                    default:
                        break;
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
