using System;

namespace Test
{
    
					
    public class Program
    {
        public class Product
        {
            private string name;
            private int quantity;
            private double price;

            public Product()
            { }
            public Product(string name, int quantity, double price)
            {
                this.name = name;
                this.quantity = quantity;
                this.price = price;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public int Quantity
            {
                get { return this.quantity; }
                set { this.quantity = value; }
            }
            public double Price
            {
                get { return this.price; }
                set { this.price = value; }
            }
            public void Print()
            {
                Console.WriteLine("Product: {0}, Quantity: {1}, Price {2} leva", this.Name, this.Quantity, this.Price);
            }
        }

        public class Storemanager
        {
            private Product product1;
            private Product product2;
            private Product product3;

            public Storemanager() { }

            public Storemanager(Product p1, Product p2, Product p3)
            {
                this.product1 = p1;
                this.product2 = p2;
                this.product3 = p3;
            }

            public Product p1
            {
                get { return this.product1; }
                set { this.product1 = value; }
            }
            public Product p2
            {
                get { return this.product2; }
                set { this.product2 = value; }
            }
            public Product p3
            {
                get { return this.product3; }
                set { this.product3 = value; }
            }

            public void GetTheMostExpensiveProduct()
            {
                if (product1.Price >= product2.Price && product1.Price >= product3.Price)
                {
                    Console.WriteLine(product1.Name + " " + product1.Quantity + "" + product1.Price);

                }
                if (product2.Price >= product1.Price && product2.Price >= product3.Price)
                {
                    Console.WriteLine(product2.Name + " " + product2.Quantity + " " + product2.Price);

                }
                if (product3.Price >= product1.Price && product3.Price >= product2.Price)
                {
                    Console.WriteLine(product3.Name + " " + product3.Quantity + " " + product3.Price);

                }
            }
        }

        public static void Main()
        {
            var product1 = new Product("Mlqko", 5, 2.5);
            var product2 = new Product("Olio", 2, 5);
            var product3 = new Product("Kafe", 1, 3);
            product1.Print();
            product2.Print();
            product3.Print();
            var magazin = new Storemanager(product1, product2, product3);
            magazin.GetTheMostExpensiveProduct();

        }
    }
}


