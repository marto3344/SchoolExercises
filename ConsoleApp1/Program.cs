using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shirt1 = new Shirt("red", "car");
            var shirt2 = new Shirt("blue", "bike");
            var shirt3 = new Shirt("black", "gun");
            var shirt4 = new Shirt("pink", "rose");
            var shirt5 = new Shirt("yellow", "cat");
            shirt1.Print();
            var chekmedje = new Chekmedje(shirt1, shirt2, shirt3, shirt4, shirt5);          
            chekmedje.PrintInfo();
      
           
        }
    }
}
