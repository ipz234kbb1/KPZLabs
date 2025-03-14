using System.Collections.Generic;

namespace SubscriptionFactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            SubscriptionName = "Educational Subscription";
            MonthlyFee = 4.99m;
            MinimumPeriod = 6;
            Channels.AddRange(new List<string> { "Документальні", "Історія", "Наука" });
            AdditionalFeatures.Add("Додаткові навчальні матеріали");
        }
    }
}