
namespace Task_4
{
    public class Triangle : IShape
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public double GetArea()
        {
            var p = (Side1 + Side2 + Side3) / 2;

            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }


}
