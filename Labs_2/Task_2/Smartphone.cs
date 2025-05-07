namespace Task_2
{
    public class Smartphone : IDevice
    {
        private string _brand;
        public Smartphone(string brand) => _brand = brand;
        public string GetInfo() => $"Смартфон бренду {_brand}";
    }
}

