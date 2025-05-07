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

            Console.WriteLine("=== ВИРОБНИЦТВО ТЕХНІКИ ===\n");

            ShowBrandDevices(new iPhoneFactory(), "iPhone");
            ShowBrandDevices(new XiaomiFactory(), "Xiaomi");
            ShowBrandDevices(new GalaxyFactory(), "Galaxy");

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        static void ShowBrandDevices(IDeviceFactory factory, string brandName)
        {
            Console.WriteLine($"--- Техніка бренду {brandName} ---");
            Console.WriteLine(factory.CreateLaptop().GetInfo());
            Console.WriteLine(factory.CreateNetbook().GetInfo());
            Console.WriteLine(factory.CreateEBook().GetInfo());
            Console.WriteLine(factory.CreateSmartphone().GetInfo());
            Console.WriteLine();
        }
    }
}
