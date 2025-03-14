using System;

namespace SubscriptionFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            ISubscriptionFactory webSiteFactory = new WebSite();
            ISubscriptionFactory mobileAppFactory = new MobileApp();
            ISubscriptionFactory managerCallFactory = new ManagerCall();

            Console.WriteLine("Створення підписок через WebSite:");
            Subscription wsDomestic = webSiteFactory.CreateSubscription("domestic");
            Subscription wsEducational = webSiteFactory.CreateSubscription("educational");
            Subscription wsPremium = webSiteFactory.CreateSubscription("premium");
            Console.WriteLine(wsDomestic);
            Console.WriteLine(wsEducational);
            Console.WriteLine(wsPremium);

            Console.WriteLine("============================================");

            Console.WriteLine("Створення підписок через MobileApp:");
            Subscription maDomestic = mobileAppFactory.CreateSubscription("domestic");
            Subscription maEducational = mobileAppFactory.CreateSubscription("educational");
            Subscription maPremium = mobileAppFactory.CreateSubscription("premium");
            Console.WriteLine(maDomestic);
            Console.WriteLine(maEducational);
            Console.WriteLine(maPremium);

            Console.WriteLine("============================================");

            Console.WriteLine("Створення підписок через ManagerCall:");
            Subscription mcDomestic = managerCallFactory.CreateSubscription("domestic");
            Subscription mcEducational = managerCallFactory.CreateSubscription("educational");
            Subscription mcPremium = managerCallFactory.CreateSubscription("premium");
            Console.WriteLine(mcDomestic);
            Console.WriteLine(mcEducational);
            Console.WriteLine(mcPremium);

            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
