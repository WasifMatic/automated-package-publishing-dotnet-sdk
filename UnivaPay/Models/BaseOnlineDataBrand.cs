// <copyright file="BaseOnlineDataBrand.cs" company="APIMatic">
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
    /// BaseOnlineDataBrand.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BaseOnlineDataBrand
    {
        /// <summary>
        /// AlipayOnline.
        /// </summary>
        [EnumMember(Value = "alipay_online")]
        AlipayOnline,

        /// <summary>
        /// AlipayPlusOnline.
        /// </summary>
        [EnumMember(Value = "alipay_plus_online")]
        AlipayPlusOnline,

        /// <summary>
        /// PayPayOnline.
        /// </summary>
        [EnumMember(Value = "pay_pay_online")]
        PayPayOnline,

        /// <summary>
        /// WeChatOnline.
        /// </summary>
        [EnumMember(Value = "we_chat_online")]
        WeChatOnline,

        /// <summary>
        /// DBaraiOnline.
        /// </summary>
        [EnumMember(Value = "d_barai_online")]
        DBaraiOnline
    }
}