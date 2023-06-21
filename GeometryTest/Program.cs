using ClassLibrary_DZ;

namespace GeometryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareArea = GeometryCalculator.CalculateSquareArea(5);
            double rectangleArea = GeometryCalculator.CalculateRectangleArea(3, 4);
            double triangleArea = GeometryCalculator.CalculateTriangleArea(6, 8);

            Console.WriteLine("Площадь квадрата: " + squareArea);
        }
    }
    }
            
