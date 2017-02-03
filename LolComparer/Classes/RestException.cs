using System;
using System.Net;

namespace LolComparer.Classes
{
    class RestException : ApplicationException
    {
        public HttpStatusCode ResponseHttpStatusCode { get; set; }
        public string ResponseContent { get; set; }
        public string ResponseErrorMessage { get; set; }

        public RestException(string responseContent, string responseErrorMessage, Exception responseErrorException)
            : base(responseContent + " " + responseErrorMessage, responseErrorException)
        {
            ResponseContent = responseContent;
            ResponseErrorMessage = responseErrorMessage;
        }

        public RestException(string responseContent, string responseErrorMessage, HttpStatusCode responseHttpStatusCode, Exception responseErrorException)
            : base(responseContent + " " + responseErrorMessage + " HttpStatusCode: " + responseHttpStatusCode, responseErrorException)
        {
            ResponseContent = responseContent;
            ResponseErrorMessage = responseErrorMessage;
            ResponseHttpStatusCode = responseHttpStatusCode;
        }
    }
}
