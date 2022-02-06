using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDostavki
{
    public  class DeliverySystem
    {
        //List<Client>clients = new List<Client>();
        Dictionary<string, List<Order>> clientorders = new Dictionary<string, List<Order>>();
        public string AddClient(Client client)
        {
            if (CheckClient(client)) return $"This client already exists!";          
            var orders=new List<Order>();
            clientorders.Add(client.Name, orders);
            return $"Successfully added {client.Name}";
        }
        public string AddOrder(Client client, Order order)
        {
            if (!CheckClient(client)) return $"This client doesn't exist!";
            if (CheckOrder(client, order)) return $"This order already exist";
            clientorders[client.Name].Add(order);
            return $"Order added successfully";
            
        }
        public string RemoveOrder(Client client, Order order)
        {
            if (!CheckClient(client)) return $"This client doesn't exist!";
            if (!CheckOrder(client, order)) return $"This order doesn't exist";
            foreach (var item in clientorders[client.Name])
            {
                if (item.Description==order.Description&&item.Deliver.ToString()==order.Deliver.ToString())
                {
                    clientorders[client.Name].Remove(item);
                    break;
                }
            }
            //clientorders[client.Name].Remove(order);
            return $"Order removed successfully!";
        }

        public string OrdersInfo(Client client)
        {
            if (!CheckClient(client)) return $"This client doesn't exist!";
            string result = "";
            foreach (var order in clientorders[client.Name])
            {
                result += order.ToString();
            }
            return result;
        }
        public string ClientInfo(Client client)
        {
            if (!CheckClient(client)) return $"This client doesn't exist!";
            return client.ToString()+$" Total orders: {clientorders[client.Name].Count}";
        }


        private bool CheckClient(Client client)
        {
            
            foreach (var item in clientorders.Keys)
            {
                if (client.Name==item)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckOrder(Client client,Order order)
        {
            foreach (var item in clientorders[client.Name])
            {
                if (item.ToString()==order.ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
