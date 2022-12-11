namespace Program_Excerise1.ClassWork
{
    public class Rectangle1 : AbstractExampleOfShape
    {
        private int length;
        private int width;
        private double area;
        public Rectangle1(int length ,int width)
        {
            this.length = length;
            this.width = width;
        }
        public override void CalArea()
        {
            area = length * width;
        }
        public override string ToString()
        {
            return $"area of Rectangle = {area}";
        }

    }
}
