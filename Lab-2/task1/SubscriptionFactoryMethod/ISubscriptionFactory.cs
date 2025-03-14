namespace SubscriptionFactoryMethod
{
    public interface ISubscriptionFactory
    {
        Subscription CreateSubscription(string type);
    }
}