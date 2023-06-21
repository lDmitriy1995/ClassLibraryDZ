using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_DZ
{
    public class GeometryCalculator
    {
        public static double CalculateSquareArea(double side)
        {
            return side * side;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
    }
}
