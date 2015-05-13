using System;

namespace Kapta.Utility
{
    /// <summary>
    /// Utility methods for validating values
    /// </summary>
    internal static class Validator
    {
        /// <summary>
        /// Throws an exception if the value is null or whitespace
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <param name="parameterName">Name of the parameter</param>
        /// <exception cref="ArgumentNullException">When value is null or whitespace</exception>
        internal static void ThrowIfNullOrWhitespace(string value, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(parameterName);
        }

        /// <summary>
        /// Throws an exception if the value is null
        /// </summary>
        /// <param name="value">Value to validate</param>
        /// <param name="parameterName">Name of the parameter</param>
        /// <exception cref="ArgumentNullException">When value is null</exception>
        internal static void ThrowIfNull(object value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
        }
    }
}
