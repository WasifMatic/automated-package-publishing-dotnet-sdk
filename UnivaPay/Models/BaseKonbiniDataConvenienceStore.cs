// <copyright file="BaseKonbiniDataConvenienceStore.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace UnivaPay.Models
{
    /// <summary>
    /// BaseKonbiniDataConvenienceStore.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseKonbiniDataConvenienceStore
    {
        /// <summary>
        /// SevenEleven.
        /// </summary>
        [EnumMember(Value = "seven_eleven")]
        SevenEleven,

        /// <summary>
        /// FamilyMart.
        /// </summary>
        [EnumMember(Value = "family_mart")]
        FamilyMart,

        /// <summary>
        /// Lawson.
        /// </summary>
        [EnumMember(Value = "lawson")]
        Lawson,

        /// <summary>
        /// MiniStop.
        /// </summary>
        [EnumMember(Value = "mini_stop")]
        MiniStop,

        /// <summary>
        /// SeicoMart.
        /// </summary>
        [EnumMember(Value = "seico_mart")]
        SeicoMart,

        /// <summary>
        /// PayEasy.
        /// </summary>
        [EnumMember(Value = "pay_easy")]
        PayEasy,

        /// <summary>
        /// DailyYamazaki.
        /// </summary>
        [EnumMember(Value = "daily_yamazaki")]
        DailyYamazaki,

        /// <summary>
        /// YamazakiDailyStore.
        /// </summary>
        [EnumMember(Value = "yamazaki_daily_store")]
        YamazakiDailyStore
    }
}