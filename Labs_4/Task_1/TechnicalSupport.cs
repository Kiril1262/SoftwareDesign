using System;

namespace Task_1
{
    public class TechnicalSupport : SupportHandler
    {
        public override bool Handle(SupportRequest request)
        {
            if (request.Issue == "2")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Технічна підтримка вирішила вашу проблему.");
                Console.ResetColor();
                return true;
            }

            return NextHandler?.Handle(request) ?? false;
        }
    }
}


