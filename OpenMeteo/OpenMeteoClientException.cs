using System.Net;
using System.Net.Http;

namespace OpenMeteo
{
    public class OpenMeteoClientException : HttpRequestException
    {
        public HttpStatusCode StatusCode { get; }

        public OpenMeteoClientException(string message, HttpStatusCode httpStatusCode) : base(message)
        {
            StatusCode = httpStatusCode;
        }
    }
}
