using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoordinatnaSistema
{
    public class Section
    {
        private Point point1;
        private Point point2;
  
        public Section(Point aPoint1,Point aPoint2)
        {
            this.point1 = aPoint1;
            this.point2 = aPoint2;
        }
        public double LenghtSection()
        {
            if (point1.CordinateX == point2.CordinateX&& point1.CordinateY == point2.CordinateY)//Ako tochkite suvpadat nqma
            {
                return 0;
            }
            else if (point1.CordinateX==point2.CordinateX)//Ako X-vete sa ravni=> Tochkite lejat na edna prava usporedna na abscisata
            {
                return Math.Abs(this.point1.CordinateY - this.point2.CordinateY);
            }
            else if (point1.CordinateY==point2.CordinateY)//Ako Y sa ravni =>Tochkite lejat na edna prava usporedna na ordinatata
            {
                return Math.Abs(this.point1.CordinateX - this.point2.CordinateX);
            }
            else//Vsichki ostanali sluchai
            {
                double height = Math.Abs(this.point1.CordinateY - this.point2.CordinateY);
                double width = Math.Abs(this.point1.CordinateX - this.point2.CordinateX);
                return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            }
        }
    }
}
