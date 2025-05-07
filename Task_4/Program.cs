using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Проксі – Читач тексту";

            string allowedFile = "sample.txt";
            string blockedFile = "secret_data.txt";

            File.WriteAllText(allowedFile, "Привіт!\nЦе приклад тексту.");
            File.WriteAllText(blockedFile, "Це секретний файл.\nНе відкривати!");

            ISmartTextReader baseReader = new SmartTextReader();

            DrawHeader("Демонстрація логування");
            ISmartTextReader checker = new SmartTextChecker(baseReader);
            checker.ReadText(allowedFile);

            DrawHeader("Демонстрація блокування доступу");
            ISmartTextReader locker = new SmartTextReaderLocker(baseReader, "secret.*");
            locker.ReadText(blockedFile);

            DrawFooter();
        }
        private static void DrawHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string border = new string('═', title.Length + 4);
            Console.WriteLine("\n╔" + border + "╗");
            Console.WriteLine("║  " + title.ToUpper() + "  ║");
            Console.WriteLine("╚" + border + "╝\n");
            Console.ResetColor();
        }

        private static void DrawFooter()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Натисніть Enter, щоб завершити...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
