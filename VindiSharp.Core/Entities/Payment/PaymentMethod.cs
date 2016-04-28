using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;
namespace VindiSharp.Core.Entities
{
    public class PaymentMethod
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("public_name")]
        public string PublicName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("settings")]
        public string Settings { get; set; }

        [JsonProperty("set_subscription_on_success")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SubscriptionOnSuccessType SetSubscriptionOnSuccess { get; set; }

        [JsonProperty("allow_as_alternative")]
        public bool AllowAsAlternative { get; set; }

        [JsonProperty("payment_companies")]
        public List<PaymentCompany> PaymentCompanies { get; set; }

        [JsonProperty("maximum_attempts")]
        public int MaximumAttempts { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}
