using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Rectangle
    {
        private static int length;
        private static int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int newLength, int newWidth)
        {
            SetNewLength(newLength);
            SetNewWidth(newWidth);
        }
        public int GetCurrentLength()
        {
            Console.WriteLine("Current Rectangle Length is:" + length);
            return length;
        }
        public int SetNewLength(int newLength)
        {
            length = newLength;
            return length;
        }
        public int GetCurrentWidth()
        {
            Console.WriteLine("Current Rectangle Width is:" + width);
            return width;
        }
        public int SetNewWidth(int newWidth)
        {
            width = newWidth;
            return width;
        }
        public int GetPerimeter()
        {
            int rectanglePerimeter = 2 * (length + width);
            Console.WriteLine("Perimeter of Rectangle is : " + rectanglePerimeter);
            return rectanglePerimeter;
        }
        public int GetArea()
        {
            int rectangleArea = length * width;
            Console.WriteLine("Area of Rectangle is :" + rectangleArea);
            return rectangleArea;
        }
    }
}
