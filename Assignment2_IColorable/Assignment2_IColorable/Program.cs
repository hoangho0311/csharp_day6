using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_IColorable
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle(3.5, "indigo", false);
            shapes[1] = new Rectangle(2.0, 3.0);
            shapes[2] = new Square(5.8, "yellow", true);
            foreach (Shape shape_item in shapes)
            {
                switch (shape_item)
                {
                    case Square square:
                        Console.WriteLine("Area: " + square.getArea());
                        break;
                    case Rectangle rectangle:
                        Console.WriteLine("Area: " + ((Rectangle)shape_item).getArea());
                        break;
                    case Circle circle:
                        Console.WriteLine("Area: " + ((Circle)shape_item).getArea());
                        break;
                }
                if (shape_item is IColorable)
                {
                    ((Square)shape_item).HowToColor();
                }
            }

            Console.ReadKey();
        }
    }
}
