using System;

namespace Task1
{
    public class TechnicalSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string request)
        {
            Console.WriteLine("Is your issue related to technical problems? (yes/no)");
            string response = Console.ReadLine()?.ToLower();
            
            if (response == "yes")
            {
                Console.WriteLine("Technical support will help you with your issue.");
                return true;
            }
            
            return NextHandler?.HandleRequest(request) ?? false;
        }
    }

    public class BillingSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string request)
        {
            Console.WriteLine("Is your issue related to billing or payments? (yes/no)");
            string response = Console.ReadLine()?.ToLower();
            
            if (response == "yes")
            {
                Console.WriteLine("Billing support will help you with your payment issues.");
                return true;
            }
            
            return NextHandler?.HandleRequest(request) ?? false;
        }
    }

    public class AccountSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string request)
        {
            Console.WriteLine("Is your issue related to account management? (yes/no)");
            string response = Console.ReadLine()?.ToLower();
            
            if (response == "yes")
            {
                Console.WriteLine("Account support will help you with your account issues.");
                return true;
            }
            
            return NextHandler?.HandleRequest(request) ?? false;
        }
    }

    public class GeneralSupportHandler : SupportHandler
    {
        public override bool HandleRequest(string request)
        {
            Console.WriteLine("Is your issue related to general inquiries? (yes/no)");
            string response = Console.ReadLine()?.ToLower();
            
            if (response == "yes")
            {
                Console.WriteLine("General support will help you with your inquiry.");
                return true;
            }
            
            return NextHandler?.HandleRequest(request) ?? false;
        }
    }
} 