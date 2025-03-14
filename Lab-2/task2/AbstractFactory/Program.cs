using System;

namespace AbstractFactory
{
    // Інтерфейси продуктів
    public interface ILaptop
    {
        void ShowInfo();
    }

    public interface INetbook
    {
        void ShowInfo();
    }

    public interface IEBook
    {
        void ShowInfo();
    }

    public interface ISmartphone
    {
        void ShowInfo();
    }

    // Реалізації продуктів для бренду IProne
    public class IProneLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("IProne Laptop");
    }

    public class IProneNetbook : INetbook
    {
        public void ShowInfo() => Console.WriteLine("IProne Netbook");
    }

    public class IProneEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("IProne EBook");
    }

    public class IProneSmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("IProne Smartphone");
    }

    // Реалізації продуктів для бренду Kiaomi
    public class KiaomiLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi Laptop");
    }

    public class KiaomiNetbook : INetbook
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi Netbook");
    }

    public class KiaomiEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi EBook");
    }

    public class KiaomiSmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("Kiaomi Smartphone");
    }

    // Реалізації продуктів для бренду Balaxy
    public class BalaxyLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Laptop");
    }

    public class BalaxyNetbook : INetbook
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Netbook");
    }

    public class BalaxyEBook : IEBook
    {
        public void ShowInfo() => Console.WriteLine("Balaxy EBook");
    }

    public class BalaxySmartphone : ISmartphone
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Smartphone");
    }

    // Абстрактна фабрика для створення девайсів
    public interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }

    // Конкретна фабрика для бренду IProne
    public class IProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new IProneLaptop();
        public INetbook CreateNetbook() => new IProneNetbook();
        public IEBook CreateEBook() => new IProneEBook();
        public ISmartphone CreateSmartphone() => new IProneSmartphone();
    }

    // Конкретна фабрика для бренду Kiaomi
    public class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new KiaomiLaptop();
        public INetbook CreateNetbook() => new KiaomiNetbook();
        public IEBook CreateEBook() => new KiaomiEBook();
        public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
    }

    // Конкретна фабрика для бренду Balaxy
    public class BalaxyFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new BalaxyLaptop();
        public INetbook CreateNetbook() => new BalaxyNetbook();
        public IEBook CreateEBook() => new BalaxyEBook();
        public ISmartphone CreateSmartphone() => new BalaxySmartphone();
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            IDeviceFactory iProneFactory = new IProneFactory();
            Console.WriteLine("IProne Devices:");
            iProneFactory.CreateLaptop().ShowInfo();
            iProneFactory.CreateNetbook().ShowInfo();
            iProneFactory.CreateEBook().ShowInfo();
            iProneFactory.CreateSmartphone().ShowInfo();

            Console.WriteLine();
            
            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            Console.WriteLine("Kiaomi Devices:");
            kiaomiFactory.CreateLaptop().ShowInfo();
            kiaomiFactory.CreateNetbook().ShowInfo();
            kiaomiFactory.CreateEBook().ShowInfo();
            kiaomiFactory.CreateSmartphone().ShowInfo();

            Console.WriteLine();
            
            IDeviceFactory balaxyFactory = new BalaxyFactory();
            Console.WriteLine("Balaxy Devices:");
            balaxyFactory.CreateLaptop().ShowInfo();
            balaxyFactory.CreateNetbook().ShowInfo();
            balaxyFactory.CreateEBook().ShowInfo();
            balaxyFactory.CreateSmartphone().ShowInfo();
        }
    }
}
