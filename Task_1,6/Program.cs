using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Завдання 1: Адаптер ===");

            Logger logger = new Logger();
            logger.Log("Це інформаційне повідомлення.");
            logger.Warn("Це попередження.");
            logger.Error("Це повідомлення про помилку.");

            FileWriter fileWriter = new FileWriter("log.txt");
            FileLoggerAdapter fileLogger = new FileLoggerAdapter(fileWriter);
            fileLogger.Log("Це інформаційне повідомлення у файл.");
            fileLogger.Warn("Це попередження у файл.");
            fileLogger.Error("Це повідомлення про помилку у файл.");

            Console.WriteLine("\n=== Завдання 6: Легковаговик ===");

            string[] bookLines = new string[]
            {
    "Захар Беркут",
    "Переднє слово",
    "  Се був світлий весняний ранок 1241 року.",
    "На широких верховинських полонинах, між гірськими верхами Карпат, зеленіли луги.",
    "Розділ перший",
    "  Сонце саме сходило і заливало полонину золотим світлом.",
    "Вівці паслися по долинах, а пастухи сиділи на каменях, вглядаючись у далечінь.",
    "  Із-за гір долинув глухий грім — на небі не було жодної хмари.",
    "То не грім — то сурми татарської орди лунали вдалині."
            };

            BookProcessor processor = new BookProcessor();
            processor.ProcessBook(bookLines);
            string html = processor.Render();
            Console.WriteLine(html);

            Console.WriteLine("Розмір дерева верстки: " + processor.GetMemorySize() + " байт");

            Console.ReadKey();
        }
    }
}
