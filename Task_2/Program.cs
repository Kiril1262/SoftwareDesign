using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Завдання 2: Декоратор ===");
            Console.WriteLine("=== ******** ===");

            IHero warrior = new Warrior();
            warrior = new Sword(warrior);
            warrior = new Shield(warrior);
            warrior = new Boots(warrior);

            Console.WriteLine("Воїн:");
            Console.WriteLine($"Опис: {warrior.GetDescription()}");
            Console.WriteLine($"Атака: {warrior.GetAttack()}");
            Console.WriteLine($"Захист: {warrior.GetDefense()}");
            Console.WriteLine($"Здоровʼя: {warrior.GetHealth()}");
            Console.WriteLine($"Мана: {warrior.GetMana()}");

            Console.WriteLine("=== ******** ===");

            Console.WriteLine();

            IHero mage = new Mage();
            mage = new Ring(mage);
            mage = new Amulet(mage);
            mage = new Boots(mage);

            Console.WriteLine("Маг:");
            Console.WriteLine($"Опис: {mage.GetDescription()}");
            Console.WriteLine($"Атака: {mage.GetAttack()}");
            Console.WriteLine($"Захист: {mage.GetDefense()}");
            Console.WriteLine($"Здоровʼя: {mage.GetHealth()}");
            Console.WriteLine($"Мана: {mage.GetMana()}");

            Console.WriteLine("=== ******** ===");

            Console.WriteLine();

            IHero paladin = new Paladin();
            paladin = new Sword(paladin);
            paladin = new Armor(paladin);
            paladin = new Shield(paladin);

            Console.WriteLine("Паладин:");
            Console.WriteLine($"Опис: {paladin.GetDescription()}");
            Console.WriteLine($"Атака: {paladin.GetAttack()}");
            Console.WriteLine($"Захист: {paladin.GetDefense()}");
            Console.WriteLine($"Здоровʼя: {paladin.GetHealth()}");
            Console.WriteLine($"Мана: {paladin.GetMana()}");

            Console.WriteLine("=== ******** ===");

            Console.ReadKey();
        }
    }
}
