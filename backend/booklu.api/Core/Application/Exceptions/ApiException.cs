using System.Globalization;

namespace booklu.api.Core.Application.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException() : base()
        {

        }

        public ApiException(string message): base(message) { }

        public ApiException(string messagge, params object[] args)
            :base(String.Format(CultureInfo.CurrentCulture, messagge, args))
        {

        }
    }
}
