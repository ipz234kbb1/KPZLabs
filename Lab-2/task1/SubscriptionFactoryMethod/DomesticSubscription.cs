using System.Collections.Generic;

namespace SubscriptionFactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            SubscriptionName = "Domestic Subscription";
            MonthlyFee = 9.99m;
            MinimumPeriod = 1;
            Channels.AddRange(new List<string> { "Новини", "Розваги", "Спорт" });
            AdditionalFeatures.Add("Стандартна якість");
        }
    }
}