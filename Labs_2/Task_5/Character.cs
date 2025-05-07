using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_5
{
    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public string Inventory { get; set; }
        public List<string> Deeds { get; set; } = new List<string>();

        public void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Зріст: {Height}");
            Console.WriteLine($"Статура: {BodyType}");
            Console.WriteLine($"Колір волосся: {HairColor}");
            Console.WriteLine($"Колір очей: {EyeColor}");
            Console.WriteLine($"Одяг: {Clothes}");
            Console.WriteLine($"Інвентар: {Inventory}");
            if (Deeds.Any())
            {
                Console.WriteLine("Справи:");
                foreach (var deed in Deeds)
                    Console.WriteLine($"- {deed}");
            }
            Console.WriteLine();
        }
    }
}


