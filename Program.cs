using System;

interface ISmartphone
{
    string GetModel();
    string GetScreenSize();
    string GetProcessor();
}

class IPhone : ISmartphone
{
    public string GetModel()
    {
        return "iPhone";
    }

    public string GetScreenSize()
    {
        return "6.1 inches";
    }

    public string GetProcessor()
    {
        return "A14 Bionic";
    }
}

class SamsungGalaxy : ISmartphone
{
    public string GetModel()
    {
        return "Samsung Galaxy";
    }

    public string GetScreenSize()
    {
        return "6.5 inches";
    }

    public string GetProcessor()
    {
        return "Exynos 2100";
    }
}

interface ISmartphoneFactory
{
    ISmartphone CreateSmartphone();
}

class IPhoneFactory : ISmartphoneFactory
{
    public ISmartphone CreateSmartphone()
    {
        return new IPhone();
    }
}

class SamsungGalaxyFactory : ISmartphoneFactory
{
    public ISmartphone CreateSmartphone()
    {
        return new SamsungGalaxy();
    }
}

class Program
{
    static void Main()
    {
        ISmartphoneFactory iPhoneFactory = new IPhoneFactory();
        ISmartphone iPhone = iPhoneFactory.CreateSmartphone();

        ISmartphoneFactory samsungGalaxyFactory = new SamsungGalaxyFactory();
        ISmartphone samsungGalaxy = samsungGalaxyFactory.CreateSmartphone();

        Console.WriteLine("iPhone:");
        Console.WriteLine($"Model: {iPhone.GetModel()}");
        Console.WriteLine($"Screen Size: {iPhone.GetScreenSize()}");
        Console.WriteLine($"Processor: {iPhone.GetProcessor()}");
        Console.WriteLine();

        Console.WriteLine("Samsung Galaxy:");
        Console.WriteLine($"Model: {samsungGalaxy.GetModel()}");
        Console.WriteLine($"Screen Size: {samsungGalaxy.GetScreenSize()}");
        Console.WriteLine($"Processor: {samsungGalaxy.GetProcessor()}");

        Console.ReadLine();
    }
}
