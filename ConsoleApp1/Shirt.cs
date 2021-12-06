using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shirt
    {
        private string color;
        private string aplication;
        public string Color { get {return this.color; } set { this.color = value; } }
        public string Aplication{ get { return this.aplication; } set { this.aplication = value; } }

        public Shirt(string color,string application)
        {
            this.aplication = application;
            this.color = color;
        }
        public void Print()
        {
            Console.WriteLine($"T-Shirt has color {this.Color} and aplication {this.Aplication}");
        }
    }
}
