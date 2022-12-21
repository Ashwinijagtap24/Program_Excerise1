using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Excerise1.ClassWork
{
    public abstract class AbstractExampleOfShape
    {
        public abstract void CalArea();
    }
    public class Circle : AbstractExampleOfShape
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;

        }

        public override void CalArea()
        {
            area = 3.14 * r * r;
        }
        public override string ToString()
        {
            return $"Area of circle = {area}";
        }
    }
        public class Rectangle : AbstractExampleOfShape
        {
            private int l;
            private int w;

                                                                                                           public double area1;
            public Rectangle(int l, int w)
            {
                this.l = l;
                this.w = w;
            }
            public override void CalArea()
            {
                area1 = l * w;
            }
            public override string ToString()
            {
                return $"Area of rect = {area1}";
            }
        }
        public static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Rectangle r = new Rectangle(1, 6);
            c.CalArea();
            r.CalArea();
            Console.WriteLine(c);
            Console.WriteLine(r);
            Console.ReadLine();
        }

    

}
