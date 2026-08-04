// <copyright file="InstallmentFixedCycles.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;

namespace UnivaPay.Models
{
    /// <summary>
    /// InstallmentFixedCycles.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum InstallmentFixedCycles
    {
        /// <summary>
        ///3 cycles
        /// Cycles3.
        /// </summary>
        Cycles3 = 3,

        /// <summary>
        ///5 cycles
        /// Cycles5.
        /// </summary>
        Cycles5 = 5,

        /// <summary>
        ///6 cycles
        /// Cycles6.
        /// </summary>
        Cycles6 = 6,

        /// <summary>
        ///10 cycles
        /// Cycles10.
        /// </summary>
        Cycles10 = 10,

        /// <summary>
        ///12 cycles
        /// Cycles12.
        /// </summary>
        Cycles12 = 12,

        /// <summary>
        ///15 cycles
        /// Cycles15.
        /// </summary>
        Cycles15 = 15,

        /// <summary>
        ///18 cycles
        /// Cycles18.
        /// </summary>
        Cycles18 = 18,

        /// <summary>
        ///20 cycles
        /// Cycles20.
        /// </summary>
        Cycles20 = 20,

        /// <summary>
        ///24 cycles
        /// Cycles24.
        /// </summary>
        Cycles24 = 24
    }
}