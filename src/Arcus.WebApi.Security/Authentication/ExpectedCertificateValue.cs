﻿using GuardNet;

namespace Arcus.WebApi.Security.Authentication
{
    /// <summary>
    /// Represents a non-null expected certificate value to validate against the actual client certificate value.
    /// </summary>
    internal class ExpectedCertificateValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectedCertificateValue"/> class.
        /// </summary>
        /// <param name="value">The expected value.</param>
        internal ExpectedCertificateValue(string value)
        {
            Guard.NotNull(value, nameof(value), "Expected certificate value cannot be 'null'");

            Value = value;
        }

        /// <summary>
        /// Gets the string representation of the expected certificate value.
        /// </summary>
        internal string Value { get; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return Value;
        }
    }
}
