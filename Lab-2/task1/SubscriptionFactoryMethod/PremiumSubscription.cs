using System.Collections.Generic;

namespace SubscriptionFactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            SubscriptionName = "Premium Subscription";
            MonthlyFee = 19.99m;
            MinimumPeriod = 1;
            Channels.Add("Всі канали");
            AdditionalFeatures.AddRange(new List<string> { "HD", "Онлайн за запитом", "Мультиекранність" });
        }
    }
}