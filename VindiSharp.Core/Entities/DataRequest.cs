using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VindiSharp.Core.Entities
{
    public class DataRequest
    {
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Subscription Subscription
        {
            get;
            set;
        }

        [JsonProperty("charge", NullValueHandling = NullValueHandling.Ignore)]
        public Charge Charge
        {
            get;
            set;
        }


        [JsonProperty("bill", NullValueHandling = NullValueHandling.Ignore)]
        public Bill Bill
        {
            get;
            set;
        }


        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public Period Period
        {
            get;
            set;
        }

        [JsonProperty("issue", NullValueHandling = NullValueHandling.Ignore)]
        public Issue Issue
        {
            get;
            set;
        }

        [JsonProperty("payment_profile", NullValueHandling = NullValueHandling.Ignore)]
        public PaymentProfile Payment_Profile
        {
            get;
            set;
        }

        //[JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        //public Message Message
        //{
        //    get;
        //    set;
        //}
    }
}
