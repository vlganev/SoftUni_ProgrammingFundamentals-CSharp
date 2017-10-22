using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            Dictionary<string, double> menu = new Dictionary<string, double>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] inputMenu = Console.ReadLine().Split(new char[] { '-' });
                string item = inputMenu[0];
                double price = double.Parse(inputMenu[1]);

                if (!menu.ContainsKey(item))
                {
                    menu.Add(item, price);
                }
                else
                {
                    menu[item] = price;
                }

            }

            List<Client> clientsList = new List<Client>();
            bool canContinue = true;

            while (canContinue)
            {
                string inputRequest = Console.ReadLine();
                if (inputRequest == "end of clients")
                {
                    canContinue = false;
                    break;
                }
                string[] tempParse = inputRequest.Split(new char[] { ',', '-' });
                string client = tempParse[0];
                string servedItem = tempParse[1];
                double count = double.Parse(tempParse[2]);

                if (menu.ContainsKey(servedItem))
                {

                    Client currClient = new Client();
                    currClient.ShopList = new Dictionary<string, double>();
                    currClient.Name = client;
                    currClient.ShopList.Add(servedItem, count);
                    currClient.Bill = menu[servedItem] * count;

                    if (clientsList.Any(c => c.Name == client))
                    {
                        Client existingClient = clientsList.First(c => c.Name == client);
                        if (existingClient.ShopList.ContainsKey(servedItem))
                        {
                            existingClient.ShopList[servedItem] += count;
                            existingClient.Bill += menu[servedItem] * count;
                        }
                        else
                        {
                            existingClient.ShopList[servedItem] = count;
                            existingClient.Bill += menu[servedItem] * count;
                        }
                    }
                    else
                    {
                        clientsList.Add(currClient);
                    }
                }
             
            }

            double totalBill = 0;
            foreach (var client in clientsList.OrderBy(x => x.Name).ThenBy(x => x.Bill))
            {
                Console.WriteLine(client.Name);
                foreach (var item in client.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {client.Bill:f2}");
                totalBill += client.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }
}
