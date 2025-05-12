using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var technicalSupport = new TechnicalSupportHandler();
            var billingSupport = new BillingSupportHandler();
            var accountSupport = new AccountSupportHandler();
            var generalSupport = new GeneralSupportHandler();
            technicalSupport.SetNext(billingSupport);
            billingSupport.SetNext(accountSupport);
            accountSupport.SetNext(generalSupport);
            Console.WriteLine("Welcome to the Support System!");
            Console.WriteLine("Please describe your issue:");
            while (true)
            {
                string request = Console.ReadLine();
                if (string.IsNullOrEmpty(request)) break;

                bool handled = technicalSupport.HandleRequest(request);
                
                if (!handled)
                {
                    Console.WriteLine("We couldn't find the right support level. Let's try again.");
                }

                Console.WriteLine("\nDo you want to continue? (yes/no)");
                if (Console.ReadLine()?.ToLower() != "yes")
                {
                    break;
                }
                
                Console.WriteLine("\nPlease describe your next issue:");
            }
        }
    }
} 