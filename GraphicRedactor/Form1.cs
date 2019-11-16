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
namespace GraphicRedactor
{
    public partial class Form1 : Form
    {
        protected List<Shape> Shapes;
        protected Mode Mode;
        protected int MouseX;
        protected int MouseY;
        protected int MouseX2;
        protected int MouseY2;
        protected int Width;

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBoxDraw.Refresh();
        }
        public void DeleteShape(int number)
        {
            Shapes.RemoveAt(listBoxShapes.SelectedIndex);
            listBoxShapes.Items.RemoveAt(listBoxShapes.SelectedIndex);
            pictureBoxDraw.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Black;
            Shapes = new List<Shape>();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxShapes.Items.Count; i++)
            {
                if (listBoxShapes.GetSelected(i))
                {
                    DeleteShape(i);
                    i--;
                }             
            }
            if (listBoxShapes.Items.Count > 0)
            {
                listBoxShapes.SetSelected(0, true);
            }
        }

        private void pictureBoxDraw_Paint(object sender, PaintEventArgs e)
        {
            if (int.TryParse(textBoxWidth.Text, out Width) == false || Width < 1)
                MessageBox.Show("Помилка вводу ширини!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Draw(e.Graphics);
                
            }
            switch (Mode)
            {
                case Mode.DrawPoint:
                    break;
                case Mode.DrawEllipse:
                    e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, Width), MouseX, MouseY, MouseX2 - MouseX, MouseY2 - MouseY);
                    break;
                case Mode.DrawLine:
                    e.Graphics.DrawLine(new Pen(buttonColor.BackColor, Width), MouseX, MouseY, MouseX2, MouseY2);
                    break;
                case Mode.DrawCircle:
                    if (MouseX2 <= MouseX && MouseY2 <= MouseY)
                        e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, Width), MouseX2, MouseY2, (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)), (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)));
                    else if (MouseX2 <= MouseX && MouseY2 >= MouseY)
                        e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, Width), MouseX2, MouseY, (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)), (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)));
                    else if (MouseX2 >= MouseX && MouseY2 <= MouseY)
                        e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, Width), MouseX, MouseY2, (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)), (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)));
                 else
                    e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, Width), MouseX, MouseY, (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)), (int)Math.Sqrt(Math.Pow((MouseX2 - MouseX), 2) + Math.Pow((MouseY2 - MouseY), 2)));
                    break;
                case Mode.DrawRectangle:
                    if (MouseX2 <= MouseX && MouseY2 <= MouseY)
                        e.Graphics.DrawRectangle(new Pen(buttonColor.BackColor, Width), MouseX2, MouseY2, MouseX - MouseX2, MouseY - MouseY2);
                    else if (MouseX2 <= MouseX && MouseY2 >= MouseY)
                        e.Graphics.DrawRectangle(new Pen(buttonColor.BackColor, Width), MouseX2, MouseY, MouseX - MouseX2, MouseY2 - MouseY);
                    else if (MouseX2 >= MouseX && MouseY2 <= MouseY)
                        e.Graphics.DrawRectangle(new Pen(buttonColor.BackColor, Width), MouseX, MouseY2, MouseX2 - MouseX, MouseY - MouseY2);
                    else
                        e.Graphics.DrawRectangle(new Pen(buttonColor.BackColor, Width), MouseX, MouseY, MouseX2 - MouseX, MouseY2 - MouseY);
                    break;
                default:
                    break;
            }
            
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawPoint;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void pictureBoxDraw_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    if (Width > 3)
                        Width = 3;
                    Shape point = new OOPDraw.Point(e.X, e.Y, new Pen(buttonColor.BackColor, Width));
                    AddShape(point);
                    break;
                case Mode.DrawLine:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawEllipse:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawCircle:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
                case Mode.DrawRectangle:
                    MouseX = e.X;
                    MouseY = e.Y;
                    break;
            }
            
        }

        private void pictureBoxDraw_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {

                case Mode.DrawEllipse:
                    Shape ellipse = new Ellipse(MouseX, MouseY, e.X - MouseX, e.Y - MouseY, new Pen(buttonColor.BackColor, Width));
                    AddShape(ellipse);
                    break;
                case Mode.DrawLine:
                    Shape shape = new Line(MouseX, MouseY, e.X, e.Y, new Pen(buttonColor.BackColor, Width));
                    AddShape(shape);
                    break;
                case Mode.DrawCircle:
                    if (e.X <= MouseX && e.Y <= MouseY)
                    {
                        Shape circle = new Circle(e.X, e.Y, (int)Math.Sqrt(Math.Pow((e.X - MouseX), 2) + Math.Pow((e.Y - MouseY), 2)), new Pen(buttonColor.BackColor, Width));
                        AddShape(circle);
                    }
                    else if (e.X <= MouseX && e.Y >= MouseY)
                    {
                        Shape circle = new Circle(e.X, MouseY, (int)Math.Sqrt(Math.Pow((e.X - MouseX), 2) + Math.Pow((e.Y - MouseY), 2)), new Pen(buttonColor.BackColor, Width));
                        AddShape(circle);
                    }
                    else if (e.X >= MouseX && e.Y <= MouseY)
                    {
                        Shape circle = new Circle(MouseX, e.Y, (int)Math.Sqrt(Math.Pow((e.X - MouseX), 2) + Math.Pow((e.Y - MouseY), 2)), new Pen(buttonColor.BackColor, Width));
                        AddShape(circle);
                    }
                    else
                    {
                        Shape circle = new Circle(MouseX, MouseY, (int)Math.Sqrt(Math.Pow((e.X - MouseX), 2) + Math.Pow((e.Y - MouseY), 2)), new Pen(buttonColor.BackColor, Width));
                        AddShape(circle);
                    }
                    break;
                case Mode.DrawRectangle:
                    if (e.X <= MouseX && e.Y <= MouseY)
                    {
                        Shape rectangle1 = new OOPDraw.Rectangle(e.X, e.Y, MouseX - e.X, MouseY - e.Y, new Pen(buttonColor.BackColor, Width));
                        AddShape(rectangle1);
                    }
                    else if (e.X <= MouseX && e.Y >= MouseY)
                    {
                        Shape rectangle2 = new OOPDraw.Rectangle(e.X, MouseY, MouseX - e.X, e.Y - MouseY, new Pen(buttonColor.BackColor, Width));
                        AddShape(rectangle2);
                    }
                    else if (e.X >= MouseX && e.Y <= MouseY)
                    {
                        Shape rectangle3 = new OOPDraw.Rectangle(MouseX, e.Y, e.X - MouseX, MouseY - e.Y, new Pen(buttonColor.BackColor, Width));
                        AddShape(rectangle3);
                    }
                    else
                    {
                        Shape rectangle4 = new OOPDraw.Rectangle(MouseX, MouseY, e.X - MouseX, e.Y - MouseY, new Pen(buttonColor.BackColor, Width));
                        AddShape(rectangle4);
                    }
                     break;
                default:
                    break;
            }
            pictureBoxDraw.Refresh();
        }

        private void pictureBoxDraw_MouseMove(object sender, MouseEventArgs e)
        {  
                switch (Mode)
                {
                    case Mode.DrawLine:
                    if (e.Button == MouseButtons.Left)
                    {
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        pictureBoxDraw.Refresh();
                    }
                        break;
                    case Mode.DrawEllipse:
                    if (e.Button == MouseButtons.Left)
                    {
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        pictureBoxDraw.Refresh();
                    }
                        break;
                case Mode.DrawCircle:
                    if (e.Button == MouseButtons.Left)
                    {
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        pictureBoxDraw.Refresh();
                    }
                    break;
                case Mode.DrawRectangle:
                    if (e.Button == MouseButtons.Left)
                    {
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        pictureBoxDraw.Refresh();
                    }
                    break;
                default:
                        break;
                }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawRectangle;
        }
    }
}
