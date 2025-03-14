using System;

namespace SubscriptionFactoryMethod
{
    public class WebSite : ISubscriptionFactory
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type.ToLower())
            {
                case "domestic":
                    var domestic = new DomesticSubscription();
                    domestic.MonthlyFee *= 0.9m;
                    domestic.AdditionalFeatures.Add("Ексклюзивний контент на сайті");
                    return domestic;
                case "educational":
                    var educational = new EducationalSubscription();
                    educational.AdditionalFeatures.Add("Веб-уроки");
                    return educational;
                case "premium":
                    var premium = new PremiumSubscription();
                    premium.MonthlyFee *= 0.95m;
                    premium.AdditionalFeatures.Add("Ексклюзивний стрімінг на сайті");
                    return premium;
                default:
                    throw new ArgumentException("Невірний тип підписки");
            }
        }
    }
}