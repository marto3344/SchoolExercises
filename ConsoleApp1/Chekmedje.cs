using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Chekmedje
    {
        private Shirt shirt1;
        private Shirt shirt2;
        private Shirt shirt3;
        private Shirt shirt4;
        private Shirt shirt5;


        public Shirt Shirt1 { get { return this.shirt1; } set { this.shirt1 = value; } }
        public Shirt Shirt2 { get { return this.shirt2; } set { this.shirt2 = value; } }
        public Shirt Shirt3 { get { return this.shirt3; } set { this.shirt3 = value; } }
        public Shirt Shirt4 { get { return this.shirt4; } set { this.shirt4 = value; } }
        public Shirt Shirt5 { get { return this.shirt5; } set { this.shirt5 = value; } }
        public Chekmedje()
        {

        }
        public Chekmedje(Shirt shirt1, Shirt shirt2,Shirt shirt3,Shirt shirt4,Shirt shirt5)
        {
            this.shirt1 = shirt1;
            this.shirt2 = shirt2;
            this.shirt3 = shirt3;
            this.shirt4 = shirt4;
            this.shirt5 = shirt5;
        }
        public void PrintInfo()
        {
            this.Shirt1.Print();
            this.Shirt2.Print();
            this.Shirt3.Print();
            this.Shirt4.Print();
            this.Shirt5.Print();
        }
    }
}
