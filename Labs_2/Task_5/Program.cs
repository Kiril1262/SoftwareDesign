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

            Console.OutputEncoding = Encoding.UTF8;

            var director = new CharacterDirector();

            Console.WriteLine("Ваш герой:");
            var hero = director.CreateHero(new HeroBuilder());
            hero.DisplayInfo();

            Console.WriteLine("Ваш ворог:");
            var enemy = director.CreateEnemy(new EnemyBuilder());
            enemy.DisplayInfo();
            Console.ReadLine();
        }
    }
}
