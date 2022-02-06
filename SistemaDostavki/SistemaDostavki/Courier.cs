using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDostavki
{
    public class Courier : Person
    {
        //private double rating;
        //public double Rating { get { return this.rating; } set {  this.rating =value; } }
        public Courier(string name) : base(name)
        {
            
        }
        public override string ToString()
        {
            return string.Format("Courier Name:{0}", this.Name);
        }
    }
}