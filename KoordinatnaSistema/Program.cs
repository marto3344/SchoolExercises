using System;

namespace KoordinatnaSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            Point point1 = new Point(x1,y1);
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            Point point2 = new Point(x2, y2);
            Section section = new Section(point1, point2);
            Console.WriteLine(point1.Quadrant());
            Console.WriteLine(point2.Quadrant());
            Console.WriteLine(section.LenghtSection());
          
        }
    }
}
