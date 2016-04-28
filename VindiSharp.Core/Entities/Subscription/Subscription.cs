﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VindiSharp.Core.Enums;

namespace VindiSharp.Core.Entities
{

    public class Subscription
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_at")]
        public DateTimeOffset StartAt { get; set; }

        [JsonProperty("next_billing_at")]
        public DateTimeOffset? NextBillingAt { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("cancel_at")]
        public DateTimeOffset CancelAt { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("interval_count")]
        public int IntervalCount { get; set; }

        [JsonProperty("billing_trigger_type")]
        public BillingTriggerType BillingTriggerType { get; set; }

        [JsonProperty("billing_trigger_day")]
        public int BillingTriggerDay { get; set; }

        [JsonProperty("billing_cycles")]
        public int BillingCycles { get; set; }

        [JsonProperty("installments")]
        public int Installments { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("customer")]
        public CustomerSummary Customer { get; set; }

        [JsonProperty("plan")]
        public PlanSummary Plan { get; set; }

        [JsonProperty("product_items")]
        public List<ProductItem> ProductItems { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonProperty("current_period")]
        public Period CurrentPeriod { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
