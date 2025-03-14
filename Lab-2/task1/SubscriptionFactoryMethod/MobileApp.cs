using System;

namespace SubscriptionFactoryMethod
{
    public class MobileApp : ISubscriptionFactory
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type.ToLower())
            {
                case "domestic":
                    var domestic = new DomesticSubscription();
                    domestic.AdditionalFeatures.Add("Мобільний інтерфейс");
                    return domestic;
                case "educational":
                    var educational = new EducationalSubscription();
                    educational.AdditionalFeatures.Add("Мобільне навчання");
                    return educational;
                case "premium":
                    var premium = new PremiumSubscription();
                    premium.AdditionalFeatures.Add("Преміальна підтримка в мобільному додатку");
                    return premium;
                default:
                    throw new ArgumentException("Невірний тип підписки");
            }
        }
    }
}