namespace Task_2
{
    public class Laptop : IDevice
    {
        private string _brand;
        public Laptop(string brand) => _brand = brand;
        public string GetInfo() => $"Ноутбук бренду {_brand}";
    }
}


