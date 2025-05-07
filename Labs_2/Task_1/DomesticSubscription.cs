using System;
using System.Collections.Generic;

namespace Task_1
{
    public class DomesticSubscription : Subscription
    {
        public override decimal MonthlyFee => 5.99m;
        public override int MinimumPeriodMonths => 3;
        public override List<string> Channels => new List<string> { "Новини", "Розваги", "Спорт" };
        public override List<string> Features => new List<string> { "HD-якість", "Один пристрій" };
        public string SubscriptionName => "Домашня підписка";

        public void DescribeBenefits()
        {
            Console.WriteLine("🏠 Ця підписка ідеально підходить для домашнього перегляду.");
            Console.WriteLine("🔹 Включає базовий набір популярних каналів.");
        }
    }
}

