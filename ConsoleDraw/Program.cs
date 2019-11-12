using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OOPDraw;
using System.Diagnostics;
namespace ConsoleDraw
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Введiть кiлькiсть елементiв, якi згенеруються на весь екран: ");
            int n = int.Parse(Console.ReadLine());
            DrawElements(GetArray(n));
            Console.WriteLine(" Для завершення натиснiть кнопку!");
            Console.ReadKey();

        }
        public static Shape[] GetArray(int n)
        {
            Random rnd = new Random();
            Shape[] shapes = new Shape[n];
            for (int i = 0; i < shapes.Length; i++)
            {
                Pen pen = new Pen(Color.FromArgb(rnd.Next(256),
                                                 rnd.Next(256),
                                                 rnd.Next(256), rnd.Next(0,5)
                    ));
                int elements = rnd.Next(0, 5);
                switch (elements)
                {
                    case 0:
                        shapes[i] = new OOPDraw.Point(rnd.Next(0, 1000),
                                                      rnd.Next(0, 1000), pen);
                        break;
                    case 1:
                        shapes[i] = new Ellipse(rnd.Next(0, 1000),
                                                rnd.Next(0, 1000),
                                                rnd.Next(0, 200),
                                                rnd.Next(0, 200), pen);
                        break;
                    case 2:
                        shapes[i] = new Line(rnd.Next(0, 1000),
                                             rnd.Next(0, 1000),
                                             rnd.Next(0, 1000),
                                             rnd.Next(0, 1000), pen);
                        break;
                    case 3:
                        shapes[i] = new Circle(rnd.Next(0, 1000),
                                               rnd.Next(0, 1000),
                                               rnd.Next(0, 200), pen);
                        break;
                    case 4:
                        shapes[i] = new OOPDraw.Rectangle(rnd.Next(0, 1000),
                                                          rnd.Next(0, 1000),
                                                          rnd.Next(0, 1000),
                                                          rnd.Next(0, 1000), pen);
                        break;
                    default:
                        break;
                }

            }
            return shapes;
        }
        public static void DrawElements(Shape[] shapes)
        {
            IntPtr intPtr = Process.GetCurrentProcess().MainWindowHandle;
            Graphics graphics = Graphics.FromHwnd(intPtr);
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw(graphics);
            }
        }
    }
}
