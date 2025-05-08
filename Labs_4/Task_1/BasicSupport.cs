using System;

namespace Task_1
{
    public class BasicSupport : SupportHandler
    {
        public override bool Handle(SupportRequest request)
        {
            if (request.Issue == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Базова підтримка вирішила вашу проблему.");
                Console.ResetColor();
                return true;
            }

            return NextHandler?.Handle(request) ?? false;
        }
    }
}


