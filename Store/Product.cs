using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        string name;
        int quantitiy;
        double price;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Quantity
        {
            get { return this.quantitiy; }
            set { this.quantitiy = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public Product()
        {

        }
        public Product(string aName,int aQuantity,double aPrice)
        {
            this.Name = aName;
            this.Quantity = aQuantity;
            this.Price = aPrice;
           
        }
        public void Print()
        {
            Console.WriteLine($"Product: {this.Name}, Quantity: {this.Quantity}, Price {this.Price} leva");
        }
    }
}
