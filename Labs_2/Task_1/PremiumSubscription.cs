using System;
using System.Collections.Generic;

namespace Task_1
{
    public class PremiumSubscription : Subscription
    {
        public override decimal MonthlyFee => 12.99m;
        public override int MinimumPeriodMonths => 6;
        public override List<string> Channels => new List<string> { "Фільми", "Серіали", "Спорт", "Новини" };
        public override List<string> Features => new List<string> { "4K-якість", "П’ять пристроїв", "Без реклами" };
        public string SubscriptionName => "Преміум підписка";

        public void DescribeBenefits()
        {
            Console.WriteLine("💎 Максимальний досвід перегляду для вимогливих користувачів.");
            Console.WriteLine("🚀 Без реклами, з високоякісним контентом на кількох пристроях.");
        }
    }
}

