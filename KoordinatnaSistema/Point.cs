using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoordinatnaSistema
{
    public class Point
    {
        private double cordinateX;
        private double cordinateY;
        public double CordinateX { get {return this.cordinateX; } set { this.cordinateX = value; } }
        public double CordinateY { get { return this.cordinateY; } set { this.cordinateY = value; } }
        public Point(double x,double y)
        {
            this.CordinateX = x;
            this.CordinateY = y;
        }
        public  string Quadrant()
        {
            if (this.cordinateX > 0 && this.cordinateY > 0)
            {
                return $"First Quadrant";
            }
            else if (this.cordinateX < 0 && this.cordinateY > 0)
            {
                return $"Second Quadrant";
            }
            else if (this.cordinateX < 0 && this.cordinateY < 0)
            {
                return $"Third Quadrant";
            }
            else if (this.cordinateX > 0 && this.cordinateY < 0)
            {
                return $"Fourth Quadrant";
            }
            else 
            {
                return OnAxis();
            }
         
        }
        private string OnAxis()
        {
            if (this.cordinateX==0&&this.cordinateY!=0)
            {
                return $"On Y-axis";
            }
            else if (this.cordinateX != 0 &&this.cordinateY == 0)
            {
                return $"On X-axis";
            }
            else
            {
                return $"On Start";
            }
        }
    }
}
