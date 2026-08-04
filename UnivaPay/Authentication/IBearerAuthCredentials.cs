// <copyright file="IBearerAuthCredentials.cs" company="APIMatic">
// UnivaPay
//
// This file was automatically generated for Univapay by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>

namespace UnivaPay.Authentication
{
    /// <summary>
    /// Authentication configuration interface for BearerAuth.
    /// </summary>
    public interface IBearerAuthCredentials
    {
        /// <summary>
        /// Gets string value for secretKey.
        /// </summary>
        string SecretKey { get; }

        /// <summary>
        /// Gets string value for jwtToken.
        /// </summary>
        string JwtToken { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="secretKey"> The string value for the secret key.</param>
        /// <param name="jwtToken"> The string value for the JWT token.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string secretKey, string jwtToken);
    }
}