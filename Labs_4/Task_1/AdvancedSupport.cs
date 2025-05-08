using System;

namespace Task_1
{
    public class AdvancedSupport : SupportHandler
    {
        public override bool Handle(SupportRequest request)
        {
            if (request.Issue == "3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Розширена підтримка вирішила вашу проблему.");
                Console.ResetColor();
                return true;
            }

            return NextHandler?.Handle(request) ?? false;
        }
    }
}


