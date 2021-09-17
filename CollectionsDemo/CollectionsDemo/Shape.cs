using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public abstract class Shape
    {
        public string color;
        public void setColor(string str)
        {
            this.color = str;
        }

        public string getColor()
        {
            return this.color;
        }

        public abstract double Area();
    }

   public class Rectangle : Shape
    {
        public int Length;
        public int Width;

        public Rectangle(int Length, int Width, string str)
        {
            setColor(str);
            this.Length = Length;
            this.Width = Width;
        }

        public override double Area()
        {
            return this.Length * this.Width;
        }

        public void displayArea()
        {
            Console.WriteLine("Area of Rectangle is = " + Area());
        }

    }
}
