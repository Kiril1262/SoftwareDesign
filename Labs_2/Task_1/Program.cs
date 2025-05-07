using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<SubscriptionCreator> creators = new List<SubscriptionCreator>
            {
                new WebSite(),
                new MobileApp(),
                new ManagerCall()
            };

            string[] subscriptionTypes = { "Domestic", "Educational", "Premium" };

            foreach (var creator in creators)
            {
                foreach (var type in subscriptionTypes)
                {
                    Console.WriteLine($"\n👉 Створення підписки типу '{type}':");
                    Subscription subscription = creator.CreateSubscription(type);
                    subscription.ShowDetails();
                    Console.WriteLine(new string('-', 40));
                }
            }

            Console.WriteLine("\n✅ Усі підписки успішно створені!");
            Console.ReadLine();
        }
    }
}
