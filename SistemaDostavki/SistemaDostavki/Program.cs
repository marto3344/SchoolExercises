using System;

namespace SistemaDostavki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliverySystem dS=new DeliverySystem();
            string[] input=Console.ReadLine().Split(',');
            while (input[0]!="End")
            {
                switch (input[0])
                {
                    case "Add Client":
                        Console.WriteLine(dS.AddClient(new Client(input[1]))); 
                        break;
                    case "Add Order":
                        Client client = new Client(input[1]);
                        Courier courier = new Courier(input[3]);
                        Console.WriteLine(dS.AddOrder(client, new Order(client, input[2], courier)));
                        break;
                    case "Remove Order":
                        Client client1 = new Client(input[1]);
                        Courier courier1 = new Courier(input[3]);
                        Console.WriteLine(dS.RemoveOrder(client1, new Order(client1, input[2], courier1))); ;
                        break;
                    case "Orders Info":
                        Console.WriteLine(dS.OrdersInfo(new Client(input[1]))); 
                        break;
                    case "Client Info":
                        Console.WriteLine(dS.ClientInfo(new Client(input[1]))); 
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
                input = Console.ReadLine().Split(',');
            }
        }
    }
}
