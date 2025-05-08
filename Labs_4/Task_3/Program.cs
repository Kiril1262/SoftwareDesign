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
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "LightHTML – Компонувальник зі Спостерігачем та Стратегією";

            var div = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
            div.AddClass("container");

            var header = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
            header.AddClass("main-title");
            header.AddChild(new LightTextNode("Вітаємо у LightHTML!"));

            var paragraph = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
            paragraph.AddClass("description");
            paragraph.AddChild(new LightTextNode("Це приклад використання патернів Компонувальник, Спостерігач і Стратегія."));

            // Стратегія завантаження зображень
            var fileImage = new ImageElement("images/logo.png", new FileImageStrategy());
            fileImage.AddClass("logo-image");

            var networkImage = new ImageElement("https://example.com/logo.png", new NetworkImageStrategy());
            networkImage.AddClass("remote-image");

            // Додавання елементів
            div.AddChild(header);
            div.AddChild(paragraph);
            div.AddChild(fileImage);
            div.AddChild(networkImage);

            // Слухачі подій
            header.AddEventListener("click", new ClickListener());
            paragraph.AddEventListener("mouseover", new MouseOverListener());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Результат рендерингу LightHTML:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(div.OuterHTML);
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Симуляція подій:");
            Console.ResetColor();

            // Симуляція подій
            header.TriggerEvent("click");
            paragraph.TriggerEvent("mouseover");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Натисніть Enter, щоб завершити...");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
