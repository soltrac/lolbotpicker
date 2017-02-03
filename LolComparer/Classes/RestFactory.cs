using System;
using System.Linq;
using System.Net;
using RestSharp;

namespace LolComparer.Classes
{
    class RestFactory
    {
        private readonly string _baseUrl;
        private readonly CookieContainer _cookieContainer;

        public RestFactory(string site, CookieContainer cc = null)
        {
            _baseUrl = site;
            _cookieContainer = cc;
        }
        
        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(_baseUrl);
            if (_cookieContainer != null)
                client.CookieContainer = _cookieContainer;            
            var response = client.Execute<T>(request);
            if (response.StatusCode == HttpStatusCode.InternalServerError
                || response.StatusCode == HttpStatusCode.ServiceUnavailable
                || response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.Unauthorized
                || response.StatusCode == HttpStatusCode.MethodNotAllowed
                || response.StatusCode == HttpStatusCode.Forbidden
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == 0)
            {
                var requestParameters = request.Parameters.Aggregate(Environment.NewLine, (current, parameter) => current + (parameter.Value + Environment.NewLine + Environment.NewLine));
                var exception = new RestException(requestParameters + response.Content, response.ErrorMessage, response.StatusCode, response.ErrorException);
                throw exception;
            }
            return response.Data;
        }

        public string Execute(RestRequest request)
        {
            var client = new RestClient(_baseUrl);
            if (_cookieContainer != null)
                client.CookieContainer = _cookieContainer;
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.InternalServerError
                || response.StatusCode == HttpStatusCode.ServiceUnavailable
                || response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.Unauthorized
                || response.StatusCode == HttpStatusCode.MethodNotAllowed
                || response.StatusCode == HttpStatusCode.Forbidden
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == 0)
            {
                var requestParameters = request.Parameters.Aggregate(Environment.NewLine, (current, parameter) => current + (parameter.Value + Environment.NewLine + Environment.NewLine));
                var exception = new RestException(requestParameters + response.Content, response.ErrorMessage, response.StatusCode, response.ErrorException);
                throw exception;
            }
            return response.Content;
        }

        public void ExecuteAsync(RestRequest request, Action<IRestResponse> callBack)
        {
            var client = new RestClient(_baseUrl);
            if (_cookieContainer != null)
                client.CookieContainer = _cookieContainer;
            client.ExecuteAsync(request, callBack);
        }        
    }
}
