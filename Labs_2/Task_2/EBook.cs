namespace Task_2
{
    public class EBook : IDevice
    {
        private string _brand;
        public EBook(string brand) => _brand = brand;
        public string GetInfo() => $"Електронна книга бренду {_brand}";
    }
}

