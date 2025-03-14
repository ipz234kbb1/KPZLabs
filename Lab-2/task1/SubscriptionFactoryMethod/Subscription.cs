using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionFactoryMethod
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumPeriod { get; set; }
        public List<string> Channels { get; set; }
        public List<string> AdditionalFeatures { get; set; }
        public string SubscriptionName { get; protected set; }

        public Subscription()
        {
            Channels = new List<string>();
            AdditionalFeatures = new List<string>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Підписка: {SubscriptionName}");
            sb.AppendLine($"Щомісячна плата: {MonthlyFee:C}");
            sb.AppendLine($"Мінімальний період: {MinimumPeriod} місяць(і/ів)");
            sb.AppendLine("Канали: " + (Channels.Count > 0 ? string.Join(", ", Channels) : "відсутні"));
            sb.AppendLine("Додаткові можливості: " + (AdditionalFeatures.Count > 0 ? string.Join(", ", AdditionalFeatures) : "відсутні"));
            return sb.ToString();
        }
    }
}