using System;

namespace Task_1
{
    public class MobileApp : SubscriptionCreator
    {
        public override Subscription CreateSubscription(string type)
        {
            Console.WriteLine("📱 [APP] Створення підписки через мобільний додаток...");

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


