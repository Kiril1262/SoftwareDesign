using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var runway1 = new Runway();
            var runway2 = new Runway();

            var aircraft1 = new Aircraft("Борт A1");
            var aircraft2 = new Aircraft("Борт A2");

            var commandCentre = new CommandCentre(
                new[] { runway1, runway2 },
                new[] { aircraft1, aircraft2 }
            );

            commandCentre.RequestLanding(aircraft1);
            commandCentre.RequestLanding(aircraft2);
            commandCentre.RequestTakeOff(aircraft1);
            commandCentre.RequestLanding(aircraft2);
            Console.ReadKey();
        }
    }
}
