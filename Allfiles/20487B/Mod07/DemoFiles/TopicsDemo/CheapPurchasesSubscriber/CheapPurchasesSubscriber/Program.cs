using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapPurchasesSubscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cheap Purchases Subscriber";

            SubscriptionClient subscriptionClient = SubscriptionClient.Create("productsalestopic", "CheapPurchases");

            // Continuously process messages received from the ExpensivePurchases subscription 
            while (true)
            {
                BrokeredMessage message = subscriptionClient.Receive();

                if (message != null)
                {
                    try
                    {
                        Console.WriteLine("Received purchase: Message id: {0}, Product name: {1}, Product price: {2}.", message.MessageId, message.Properties["ProductName"], message.Properties["ProductPrice"]);

                        // Remove printed message from subscription
                        message.Complete();
                    }
                    catch (Exception)
                    {
                        // In case of an error, unlock the message in subscription
                        message.Abandon();
                    }
                }
            }
        }
    }
}
