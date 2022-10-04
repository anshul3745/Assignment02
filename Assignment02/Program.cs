using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            int option = 0;

            Console.WriteLine();
            Console.WriteLine("1 = Get Rectangle Length");
            Console.WriteLine("2 = Change Rectangle Length");
            Console.WriteLine("3 = Get Rectangle Width");
            Console.WriteLine("4 = Change Rectangle Width");
            Console.WriteLine("5 = Get Rectangle perimeter");
            Console.WriteLine("6 = Get Rectangle Area");
            Console.WriteLine("7 = Exit");

            Console.WriteLine();
            Console.WriteLine("Please select any option to perform Operation : ");

            while (option != 7)
            {
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        rectangle.GetCurrentLength();
                        break;
                    case 2:
                        Console.WriteLine("Please enter rectangle length to change:");
                        int newLength = Convert.ToInt32(Console.ReadLine());
                        while (newLength <= 0)
                        {
                            Console.WriteLine("Please enter a valid number greater than 0");
                            newLength = Convert.ToInt32(Console.ReadLine());
                        }
                        rectangle.SetNewLength(newLength);
                        break;
                    case 3:
                        rectangle.GetCurrentWidth();
                        break;
                    case 4:
                        Console.WriteLine("Please enter rectangle width to change:");
                        int newWidth = Convert.ToInt32(Console.ReadLine());
                        while (newWidth <= 0)
                        {
                            Console.WriteLine("Please enter a valid number greater than 0");
                            newWidth = Convert.ToInt32(Console.ReadLine());
                        }
                        rectangle.SetNewWidth(newWidth);
                        break;
                    case 5:
                        rectangle.GetPerimeter();
                        break;
                    case 6:
                        rectangle.GetArea();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
