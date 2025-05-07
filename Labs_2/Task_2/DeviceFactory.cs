namespace Task_2
{
    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateNetbook();
        IDevice CreateEBook();
        IDevice CreateSmartphone();
    }
}

