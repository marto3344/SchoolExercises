using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDostavki
{
    public class Client : Person
    {      
        public Client(string name) : base(name)
        {
            
        }
        public override string ToString()
        {
            return $"Client Name: {this.Name}";
        }
    }
}
