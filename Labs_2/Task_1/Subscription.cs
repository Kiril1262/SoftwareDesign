using System.Collections.Generic;
using System;

namespace Task_1
{
    public abstract class Subscription
    {
        public abstract decimal MonthlyFee { get; }
        public abstract int MinimumPeriodMonths { get; }
        public abstract List<string> Channels { get; }
        public abstract List<string> Features { get; }

        public void ShowDetails()
        {
            Console.WriteLine($"💳 Місячна плата: {MonthlyFee} USD");
            Console.WriteLine($"📅 Мінімальний період: {MinimumPeriodMonths} місяців");
            Console.WriteLine("📺 Канали: " + string.Join(", ", Channels));
            Console.WriteLine("✨ Можливості: " + string.Join(", ", Features));

        }
    }
}
