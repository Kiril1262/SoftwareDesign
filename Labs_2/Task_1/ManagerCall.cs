using System;

namespace Task_1
{
    public class ManagerCall : SubscriptionCreator
    {
        public override Subscription CreateSubscription(string type)
        {
            Console.WriteLine("📞 [CALL] Створення підписки через дзвінок менеджера...");

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


