using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class StoreManager
    {
        private Product product1;
        private Product product2;
        private Product product3;

        public Product Procuct1 { get { return this.product1; } set { this.product1 = value; } }
        public Product Procuct2 { get { return this.product2; } set { this.product2 = value; } }
        public Product Procuct3 { get { return this.product3; } set { this.product3 = value; } }
        public StoreManager()
        {

        }
        public StoreManager(Product aProduct1, Product aProduct2, Product aProduct3)
        {
            this.product1 = aProduct1;
            this.product2 = aProduct2;
            this.product3 = aProduct3;

        }
        public void GetTheMostExpensiveProduct()
        {
            Product[] sortedProducts = new Product[3];
            sortedProducts[0] = product1;
            sortedProducts[1] = product2;
            sortedProducts[2] = product3;
            Product mostExpensiveProduct = sortedProducts.OrderByDescending(x => x.Price).First();
            Console.WriteLine($"Most Expensive product: {mostExpensiveProduct.Name}, Quantity: {mostExpensiveProduct.Quantity}, Price {mostExpensiveProduct.Price} leva");
            
        }
    }
}
