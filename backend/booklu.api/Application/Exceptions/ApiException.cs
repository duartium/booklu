using System.Globalization;

namespace booklu.api.Application.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException() : base()
        {

        }

        public ApiException(string message) : base(message) { }

        public ApiException(string messagge, params object[] args)
            : base(string.Format(CultureInfo.CurrentCulture, messagge, args))
        {

        }
    }
}
