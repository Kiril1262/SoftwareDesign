using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "LightHTML – Компонувальник";

            var div = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            div.AddClass("container");

            var header = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
            header.AddClass("main-title");
            header.AddChild(new LightTextNode("Вітаємо у LightHTML!"));

            //Приклад використання патерну.
            var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
            paragraph.AddClass("description");
            paragraph.AddChild(new LightTextNode("Це приклад використання патерну Компонувальник."));

            var image = new LightElementNode("img", DisplayType.Inline, ClosingType.SelfClosing);
            image.AddClass("sample-image");

            div.AddChild(header);
            div.AddChild(paragraph);
            div.AddChild(image);

            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Результат рендерингу LightHTML:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(div.OuterHTML);
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Натисніть Enter, щоб завершити...");
            Console.ResetColor();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
