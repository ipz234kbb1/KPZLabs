using System;

namespace SubscriptionFactoryMethod
{
    public class ManagerCall : ISubscriptionFactory
    {
        public Subscription CreateSubscription(string type)
        {
            switch (type.ToLower())
            {
                case "domestic":
                    var domestic = new DomesticSubscription();
                    domestic.AdditionalFeatures.Add("Персональна консультація менеджера");
                    return domestic;
                case "educational":
                    var educational = new EducationalSubscription();
                    educational.AdditionalFeatures.Add("Персональний навчальний супровід");
                    return educational;
                case "premium":
                    var premium = new PremiumSubscription();
                    premium.AdditionalFeatures.Add("Персональна консультація менеджера");
                    return premium;
                default:
                    throw new ArgumentException("Невірний тип підписки");
            }
        }
    }
}