using System;

namespace Secure_api.Helpers
{
    public class AppException : Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args)
            : base(String.Format(System.Globalization.CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
