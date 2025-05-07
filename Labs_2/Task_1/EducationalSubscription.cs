using System;
using System.Collections.Generic;

namespace Task_1
{
    public class EducationalSubscription : Subscription
    {
        public override decimal MonthlyFee => 3.99m;
        public override int MinimumPeriodMonths => 1;
        public override List<string> Channels => new List<string> { "Документалістика", "Освітні програми" };
        public override List<string> Features => new List<string> { "Доступ до архіву", "Два пристрої" };
        public string SubscriptionName => "Освітня підписка";

        public void DescribeBenefits()
        {
            Console.WriteLine("🎓 Ідеальна для школярів, студентів та викладачів.");
            Console.WriteLine("📚 Допомагає у навчанні завдяки якісному контенту.");
        }
    }
}

