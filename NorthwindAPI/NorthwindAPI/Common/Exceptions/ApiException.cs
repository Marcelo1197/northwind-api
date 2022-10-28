using System.Globalization;

namespace NorthwindAPI.Common.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException() : base() {}

        public ApiException(string message) : base(message) { }

        public ApiException(string message, params object[] arguments) : base(String.Format(CultureInfo.CurrentCulture, message, arguments)) 
        {

        }
    }
}
