using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Rect(4, 5);
            Circle(4);
            Tri(10, 9);
        }
        static void Rect(double length, double width)
        {
            Console.WriteLine($"The Area of the rectabgle is {length * width}.");
        }
        static void Circle(double radius)
        {
            Console.WriteLine($"The Area of the circle is {(Math.PI * Math.Pow(radius, 2))}.");
        }
        static void Tri(double bottom, double height)
        {
            Console.WriteLine($"The Area of the Triangle is {0.5 * bottom * height}");
        }
        static void Calculate_Cost()
        {

        }


    }
}
