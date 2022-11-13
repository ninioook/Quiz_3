namespace Task_4
{
    public class Trapezoid : IShape
    {
        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public double D { get; set; }

        public double GetArea()
        {
            double p = (A + B + C + D) / 2;

            var area = ((A + B) / (A - B) * Math.Sqrt((p - A) * (p - B) * (p - A - C) * (p - A - D)));

            return area;
        }

        public double GetPerimeter()
        {
            var p = A + B + C + D;

            return p;
        }
    }
}
