using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Mlqko", 5, 2.5);
            var product2 = new Product("Olio", 2, 5);
            var product3 = new Product("Kafe", 1, 3);
            product1.Print();
            product2.Print();
            product3.Print();
            var magazin = new StoreManager(product1, product2, product3);
            magazin.GetTheMostExpensiveProduct();
        }
    }
}
