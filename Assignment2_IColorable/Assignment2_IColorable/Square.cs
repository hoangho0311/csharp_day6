using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_IColorable
{
    public class Square : Rectangle, IColorable
    {
        public Square()
        {
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public double getSide()
        {
            return getWidth();
        }

        public void setSide(double side)
        {
            base.setWidth(side);
            base.setLength(side);
        }
        public override void setWidth(double width)
        {
            setSide(width);
        }

        public override void setLength(double length)
        {
            setSide(length);
        }

        public double getArea()
        {
            return getSide() * getSide();
        }

        public override string ToString()
        {
            return "A Square with side="
                    + getSide()
                    + ", which is a subclass of "
                    + base.ToString();
        }

        public void HowToColor()
        {
            Console.WriteLine("Color all four sides..");
        }
    }
}
