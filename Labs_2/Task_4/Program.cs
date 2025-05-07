using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Virus grandfather = VirusFamilyBuilder.CreateFamily();
            Console.WriteLine("ОРИГІНАЛ:");
            grandfather.PrintInfo();

            Virus clone = (Virus)grandfather.Clone();
            clone.Name = "Клон-Дід";                    
            clone.Children[0].Name = "Клон-Батько";     

            Console.WriteLine("\nПІСЛЯ ЗМІН:");
            Console.WriteLine("Оригінал:");
            grandfather.PrintInfo();

            Console.WriteLine("Клон:");
            clone.PrintInfo();
            Console.ReadKey();
        }
    }
}
