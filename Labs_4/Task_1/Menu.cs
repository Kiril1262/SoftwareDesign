using System;

namespace Task_1
{
    public class Menu
    {
        private readonly SupportHandler _handler;

        public Menu()
        {
            var basic = new BasicSupport();
            var technical = new TechnicalSupport();
            var advanced = new AdvancedSupport();
            var supervisor = new SupervisorSupport();

            basic.SetNext(technical);
            technical.SetNext(advanced);
            advanced.SetNext(supervisor);

            _handler = basic;
        }

        public void Start()
        {
            bool resolved = false;

            while (!resolved)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nВітаємо в системі підтримки:");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Маю загальне питання");
                Console.WriteLine("2. Проблема з технікою");
                Console.WriteLine("3. Потрібна допомога з акаунтом");
                Console.WriteLine("4. Хочу поговорити з керівником");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Введіть номер опції: ");
                Console.ResetColor();

                var input = Console.ReadLine();
                var request = new SupportRequest(input);
                resolved = _handler.Handle(request);

                if (!resolved)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("На жаль, не вдалося вирішити проблему. Спробуйте ще раз.");
                    Console.ResetColor();
                }
            }
        }
    }
}

