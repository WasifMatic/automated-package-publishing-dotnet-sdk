// <copyright file="MerchantWebhookTransferScheduleConfiguration.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnivaPay.Utilities;

namespace UnivaPay.Models
{
    /// <summary>
    /// MerchantWebhookTransferScheduleConfiguration.
    /// </summary>
    public class MerchantWebhookTransferScheduleConfiguration
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        private bool? fullPeriodRequired;
        private string dayOfWeek;
        private int? weekOfMonth;
        private int? dayOfMonth;
        private string weeklyClosingDay;
        private string weeklyPayoutDay;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "full_period_required", false },
            { "day_of_week", false },
            { "week_of_month", false },
            { "day_of_month", false },
            { "weekly_closing_day", false },
            { "weekly_payout_day", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookTransferScheduleConfiguration"/> class.
        /// </summary>
        public MerchantWebhookTransferScheduleConfiguration()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantWebhookTransferScheduleConfiguration"/> class.
        /// </summary>
        /// <param name="waitPeriod">wait_period.</param>
        /// <param name="period">period.</param>
        /// <param name="fullPeriodRequired">full_period_required.</param>
        /// <param name="dayOfWeek">day_of_week.</param>
        /// <param name="weekOfMonth">week_of_month.</param>
        /// <param name="dayOfMonth">day_of_month.</param>
        /// <param name="weeklyClosingDay">weekly_closing_day.</param>
        /// <param name="weeklyPayoutDay">weekly_payout_day.</param>
        public MerchantWebhookTransferScheduleConfiguration(
            string waitPeriod = null,
            string period = null,
            bool? fullPeriodRequired = null,
            string dayOfWeek = null,
            int? weekOfMonth = null,
            int? dayOfMonth = null,
            string weeklyClosingDay = null,
            string weeklyPayoutDay = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.WaitPeriod = waitPeriod;
            this.Period = period;

            if (fullPeriodRequired != null)
            {
                this.FullPeriodRequired = fullPeriodRequired;
            }

            if (dayOfWeek != null)
            {
                this.DayOfWeek = dayOfWeek;
            }

            if (weekOfMonth != null)
            {
                this.WeekOfMonth = weekOfMonth;
            }

            if (dayOfMonth != null)
            {
                this.DayOfMonth = dayOfMonth;
            }

            if (weeklyClosingDay != null)
            {
                this.WeeklyClosingDay = weeklyClosingDay;
            }

            if (weeklyPayoutDay != null)
            {
                this.WeeklyPayoutDay = weeklyPayoutDay;
            }
        }

        /// <summary>
        /// ISO-8601 period before charges become payable.
        /// </summary>
        [JsonProperty("wait_period", NullValueHandling = NullValueHandling.Ignore)]
        public string WaitPeriod { get; set; }

        /// <summary>
        /// Transfer period selected for payouts.
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// Whether the first transfer period must be fully completed.
        /// </summary>
        [JsonProperty("full_period_required")]
        public bool? FullPeriodRequired
        {
            get
            {
                return this.fullPeriodRequired;
            }

            set
            {
                this.shouldSerialize["full_period_required"] = true;
                this.fullPeriodRequired = value;
            }
        }

        /// <summary>
        /// Payout day of week when using weekly schedules.
        /// </summary>
        [JsonProperty("day_of_week")]
        public string DayOfWeek
        {
            get
            {
                return this.dayOfWeek;
            }

            set
            {
                this.shouldSerialize["day_of_week"] = true;
                this.dayOfWeek = value;
            }
        }

        /// <summary>
        /// Week of month used by monthly schedules.
        /// </summary>
        [JsonProperty("week_of_month")]
        public int? WeekOfMonth
        {
            get
            {
                return this.weekOfMonth;
            }

            set
            {
                this.shouldSerialize["week_of_month"] = true;
                this.weekOfMonth = value;
            }
        }

        /// <summary>
        /// Day of month used by monthly schedules.
        /// </summary>
        [JsonProperty("day_of_month")]
        public int? DayOfMonth
        {
            get
            {
                return this.dayOfMonth;
            }

            set
            {
                this.shouldSerialize["day_of_month"] = true;
                this.dayOfMonth = value;
            }
        }

        /// <summary>
        /// Weekly closing day for balance aggregation.
        /// </summary>
        [JsonProperty("weekly_closing_day")]
        public string WeeklyClosingDay
        {
            get
            {
                return this.weeklyClosingDay;
            }

            set
            {
                this.shouldSerialize["weekly_closing_day"] = true;
                this.weeklyClosingDay = value;
            }
        }

        /// <summary>
        /// Weekly payout day.
        /// </summary>
        [JsonProperty("weekly_payout_day")]
        public string WeeklyPayoutDay
        {
            get
            {
                return this.weeklyPayoutDay;
            }

            set
            {
                this.shouldSerialize["weekly_payout_day"] = true;
                this.weeklyPayoutDay = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MerchantWebhookTransferScheduleConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFullPeriodRequired()
        {
            this.shouldSerialize["full_period_required"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDayOfWeek()
        {
            this.shouldSerialize["day_of_week"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeekOfMonth()
        {
            this.shouldSerialize["week_of_month"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDayOfMonth()
        {
            this.shouldSerialize["day_of_month"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklyClosingDay()
        {
            this.shouldSerialize["weekly_closing_day"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWeeklyPayoutDay()
        {
            this.shouldSerialize["weekly_payout_day"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFullPeriodRequired()
        {
            return this.shouldSerialize["full_period_required"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDayOfWeek()
        {
            return this.shouldSerialize["day_of_week"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeekOfMonth()
        {
            return this.shouldSerialize["week_of_month"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDayOfMonth()
        {
            return this.shouldSerialize["day_of_month"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyClosingDay()
        {
            return this.shouldSerialize["weekly_closing_day"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeeklyPayoutDay()
        {
            return this.shouldSerialize["weekly_payout_day"];
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"WaitPeriod = {this.WaitPeriod ?? "null"}");
            toStringOutput.Add($"Period = {this.Period ?? "null"}");
            toStringOutput.Add($"FullPeriodRequired = {(this.FullPeriodRequired == null ? "null" : this.FullPeriodRequired.ToString())}");
            toStringOutput.Add($"DayOfWeek = {this.DayOfWeek ?? "null"}");
            toStringOutput.Add($"WeekOfMonth = {(this.WeekOfMonth == null ? "null" : this.WeekOfMonth.ToString())}");
            toStringOutput.Add($"DayOfMonth = {(this.DayOfMonth == null ? "null" : this.DayOfMonth.ToString())}");
            toStringOutput.Add($"WeeklyClosingDay = {this.WeeklyClosingDay ?? "null"}");
            toStringOutput.Add($"WeeklyPayoutDay = {this.WeeklyPayoutDay ?? "null"}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}