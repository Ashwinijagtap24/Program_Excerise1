using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.LogicalAssignment
{
    //Accept radius of a circle.Display area of a circle.
    class CirCleCalculate
    {
        public static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter the number ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calculate Area of Circle");
            double Area = 2 *Math.PI * radius;
            Console.WriteLine($"area = {Area} ");
            Console.ReadLine();
        }
    }
    //Accept length and breadth of a rectangle and find perimeter
    class ReactPerimeter
    {
        static void Main(string[] args)
        {
            double length, width, perimeter;
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cal perimeter");
            perimeter = (length + width)*2;
            Console.WriteLine($"perimeter = {perimeter}");
            Console.ReadLine();
        }
    }
    //Accept two angles of triangle and find third angle.
    class TriangleThirdAngle
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first side");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entr the Second Side");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cal third variable");
            int c = 180-(a + b);
            Console.WriteLine($"THIRD SIDE = {c}");
            Console.ReadLine();
        }
    }
}
