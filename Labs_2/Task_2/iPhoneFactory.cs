namespace Task_2
{
    public class iPhoneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("iPhone");
        public IDevice CreateNetbook() => new Netbook("iPhone");
        public IDevice CreateEBook() => new EBook("iPhone");
        public IDevice CreateSmartphone() => new Smartphone("iPhone");
    }
}

