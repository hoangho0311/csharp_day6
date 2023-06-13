using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape("red", false);
            Console.WriteLine(shape);

            // Circle Test
            Circle circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            // Square Test
            Square square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);

            // Rectangle Test
            Rectangle rectangle = new Rectangle(2.0, 3.0);
            Console.WriteLine(rectangle);

            //Resize
            Console.WriteLine("\nAfter Resize: ");
            Random random = new Random();
            int percent = random.Next(0, 100);
            circle.Resize(percent);
            Console.WriteLine($"Circle: {circle}");
            square.Resize(percent);
            Console.WriteLine($"Square: {square}");
            rectangle.Resize(percent);
            Console.WriteLine($"Rectangle: {rectangle}");

            Console.ReadKey();
        }
    }
}
