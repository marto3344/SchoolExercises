using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDostavki
{
    public class Order
    {
        private Client reciever;
        private string description;
        private Courier deliver;

        public Client Reciever { get { return this.reciever; } set { this.reciever = value; } }
        public string Description { get { return this.description; } set { this.description = value; } }
        public Courier Deliver { get { return this.deliver; } set { this.deliver = value; } }

        public Order(Client reciver, string description, Courier deliver)
        {
            this.Reciever = reciver;
            this.Description = description;
            this.Deliver = deliver;
        }
        public override string ToString()
        {
            return $"Order:{this.Description} \nOrdered By:{reciever.Name} \nDeliverd By: {deliver.ToString()}\n";
        }
    }
}
