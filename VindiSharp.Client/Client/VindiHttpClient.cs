using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VindiSharp.Core.Enums;
using VindiSharp.Core.Interfaces;
using RestSharpJsonRequest = RestSharp.Newtonsoft.Json.RestRequest;
namespace VindiSharp.Client
{
    public class VindiHttpClient : IVindiHttpClient
    {

        private readonly IRestClient restClient;

        public VindiHttpClient(Uri baseUri, String ApiKey, String ApiVersion)
        {
            this.BaseUri = baseUri;

            restClient = new RestClient(new Uri(baseUri, ApiVersion));
            restClient.Authenticator = new HttpBasicAuthenticator(ApiKey, "");

            this.ApiVersion = ApiVersion;

        }
        public VindiHttpClient(Uri baseUri, String Username, String Password, String ApiVersion)
        {
            this.BaseUri = baseUri;

            restClient = new RestClient(new Uri(baseUri, ApiVersion));

            restClient.Authenticator = new HttpBasicAuthenticator(Username, Password);

            this.ApiVersion = ApiVersion;
        }
        public string ApiKey
        {
            get;
            set;

        }

        public string ApiVersion
        {
            get;
            set;
        }

        public Uri BaseUri
        {
            get;
            set;
        }

        private static Method GetMethod(VindiRequestMethod method)
        {
            Method restMethod = Method.GET;

            switch (method)
            {
                case VindiRequestMethod.Post:
                    restMethod = Method.POST;
                    break;
                case VindiRequestMethod.Get:
                    restMethod = Method.GET;
                    break;
                case VindiRequestMethod.Put:
                    restMethod = Method.PUT;
                    break;
                case VindiRequestMethod.Delete:
                    restMethod = Method.DELETE;
                    break;
                default:
                    break;
            }

            return restMethod;
        }
        public TResponse Do<TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, Dictionary<string, object> Parameters = null)
            where TResponse : class, new()
        {
            RestSharpJsonRequest request = new RestSharpJsonRequest(Resource, GetMethod(RequestMethod));
            request.RequestFormat = DataFormat.Json;
            request.RootElement = NodeName;
            request.JsonSerializer = new NewtonsoftJsonSerializer();

            AddParameters(Parameters, request);

            IRestResponse<TResponse> response = restClient.Execute<TResponse>(request);

            HandleResponse(response);

            return response.Data;
        }

        private static void AddParameters(Dictionary<string, object> Parameters, IRestRequest request)
        {
            foreach (KeyValuePair<string, object> parameter in Parameters)
            {
                request.AddParameter(parameter.Key, parameter.Value);
            }
        }


        public TResponse Do<TEntity, TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod, TEntity Parameters)
            where TResponse : class, new()
            where TEntity : class, IVindiEntity, new()
        {
            RestSharpJsonRequest request = new RestSharpJsonRequest(Resource, GetMethod(RequestMethod));

            request.RequestFormat = DataFormat.Json;
            request.RootElement = NodeName;

            request.AddJsonBody(Parameters);

            IRestResponse<TResponse> response = restClient.Execute<TResponse>(request);

            HandleResponse(response);
            return response.Data;
        }
        public void Do<TEntity>(string Resource, VindiRequestMethod RequestMethod, TEntity Parameters)
           where TEntity : class, IVindiEntity, new()
        {
            RestSharpJsonRequest request = new RestSharpJsonRequest(Resource, GetMethod(RequestMethod));

            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(Parameters);

            IRestResponse response = restClient.Execute(request);

            HandleResponse(response);

        }

        public async Task<TResponse> DoAsync<TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, Dictionary<string, object> Parameters = null)
        where TResponse : class, new()
        {
            IRestRequest request = new RestSharpJsonRequest(Resource, GetMethod(RequestMethod));
            request.RequestFormat = DataFormat.Json;

            request.RootElement = NodeName;

            AddParameters(Parameters, request);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IRestResponse<TResponse> response = await restClient.ExecuteTaskAsync<TResponse>(request, cancellationTokenSource.Token);

            HandleResponse(response);

            return response.Data;
        }

        public async Task DoAsync<TEntity>(string Resource, VindiRequestMethod RequestMethod, TEntity Parameter)

             where TEntity : class, IVindiEntity, new()
        {
            IRestRequest request = new RestSharpJsonRequest(Resource, GetMethod(RequestMethod));
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(Parameter);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IRestResponse response = await restClient.ExecuteTaskAsync(request, cancellationTokenSource.Token);

            HandleResponse(response);
        }

        public async Task<TResponse> DoAsync<TEntity, TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod, TEntity Parameter)
            where TResponse : class, new()
            where TEntity : class, IVindiEntity, new()
        {
            IRestRequest request = new RestSharpJsonRequest(Resource, GetMethod(RequestMethod));
            request.RequestFormat = DataFormat.Json;

            request.RootElement = NodeName;

            request.AddJsonBody(Parameter);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IRestResponse<TResponse> response = await restClient.ExecuteTaskAsync<TResponse>(request, cancellationTokenSource.Token);

            HandleResponse(response);

            return response.Data;
        }
        private void HandleResponse(IRestResponse response)
        {
            Int32 httpStatusCode = (int)response.StatusCode;


            if (httpStatusCode >= 400 && httpStatusCode < 500)
            {

            }
            else if (httpStatusCode >= 500)
            {

            }
        }
    }
}
