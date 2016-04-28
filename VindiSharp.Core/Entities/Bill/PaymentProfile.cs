using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class PaymentProfile
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("registry_code")]
        public string RegistryCode { get; set; }

        [JsonProperty("bank_branch")]
        public string BankBranch { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("card_expiration")]
        public string CardExpiration { get; set; }

        [JsonProperty("card_number_first_six")]
        public string CardNumberFirstSix { get; set; }

        [JsonProperty("card_number_last_four")]
        public string CardNumberLastFour { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("payment_company")]
        public PaymentCompany PaymentCompany { get; set; }
    }
}
