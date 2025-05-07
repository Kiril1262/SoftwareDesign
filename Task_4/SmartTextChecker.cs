using System;

namespace Task_4
{
    public class SmartTextChecker : ISmartTextReader
    {
        private readonly ISmartTextReader _realReader;

        public SmartTextChecker(ISmartTextReader realReader)
        {
            _realReader = realReader;
        }

        public char[][] ReadText(string filePath)
        {
            Console.WriteLine("Відкриття файлу...");
            var result = _realReader.ReadText(filePath);
            Console.WriteLine("Читання завершено.");
            Console.WriteLine("Закриття файлу...");

            int lines = result.Length;
            int chars = 0;
            foreach (var line in result)
            {
                chars += line.Length;
            }

            Console.WriteLine("Загальна кількість рядків: " + lines);
            Console.WriteLine("Загальна кількість символів: " + chars);

            return result;
        }
    }
}
