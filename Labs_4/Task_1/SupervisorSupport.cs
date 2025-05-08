using System;

namespace Task_1
{
    public class SupervisorSupport : SupportHandler
    {
        public override bool Handle(SupportRequest request)
        {
            if (request.Issue == "4")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Супервізор вирішив вашу проблему.");
                Console.ResetColor();
                return true;
            }

            return false;
        }
    }
}


