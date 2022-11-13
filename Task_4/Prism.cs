
namespace Task_4
{
    //right rectangular prism
    public class Prism : IShape
    {
        public double Height { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double GetArea()
        {
            var area = 2 * (Length * Height + Width * Height + Length * Width);

            return area;
        }

        public double GetPerimeter()
        {
            var p = 2 * (Length + Width);

            return p;
        }
    }
}
