using System;
using System.Threading;

namespace Task_3
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> _instance =
            new Lazy<Authenticator>(() => new Authenticator(), LazyThreadSafetyMode.ExecutionAndPublication);

        private Authenticator()
        {
            Console.WriteLine("Екземпляр створено.");
        }

        public static Authenticator Instance => _instance.Value;

        public void Authenticate()
        {
            Console.WriteLine("Аутентифікація виконана.");
        }
    }
}

