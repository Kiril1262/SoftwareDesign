namespace Task_2
{
    public class Netbook : IDevice
    {
        private string _brand;
        public Netbook(string brand) => _brand = brand;
        public string GetInfo() => $"Нетбук бренду {_brand}";
    }
}

