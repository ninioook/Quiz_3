namespace Task_4
{
    public class Rectangle : IShape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public double GetArea()
        {
            return Length * Width;
        }

        public double GetPerimeter()
        {
            var p = 2 * (Length + Width);
            return p;
        }
    }
}
