using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Title = "Графічний Редактор – Міст";

            DrawHeader("Графічний Редактор – Демонстрація шаблону «Міст»");

            IRenderer vector = new VectorRenderer();
            IRenderer raster = new RasterRenderer();

            Shape circle = new Circle(vector);
            Shape square = new Square(raster);
            Shape triangle = new Triangle(vector);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nРезультат рендерингу:\n");

            Console.ForegroundColor = ConsoleColor.Green;
            circle.Draw();
            Console.ForegroundColor = ConsoleColor.Yellow;
            square.Draw();
            Console.ForegroundColor = ConsoleColor.Magenta;
            triangle.Draw();

            Console.ResetColor();

            Console.WriteLine("\nНатисніть Enter, щоб завершити...");
            Console.ReadLine();
        }
        private static void DrawHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string border = new string('═', title.Length + 4);
            Console.WriteLine("╔" + border + "╗");
            Console.WriteLine("║  " + title + "  ║");
            Console.WriteLine("╚" + border + "╝");
            Console.ResetColor();
        }
    }
}
