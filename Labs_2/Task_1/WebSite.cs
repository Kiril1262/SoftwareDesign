using System;

namespace Task_1
{
    public class WebSite : SubscriptionCreator
    {
        public override Subscription CreateSubscription(string type)
        {
            Console.WriteLine("🌐 [WEB] Створення підписки через сайт...");

            if (type == "Domestic")
                return new DomesticSubscription();
            else if (type == "Educational")
                return new EducationalSubscription();
            else if (type == "Premium")
                return new PremiumSubscription();
            else
                throw new ArgumentException("❌ Невідомий тип підписки.");
        }
    }
}


