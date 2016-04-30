using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if !NET35
using System.Threading;
using System.Threading.Tasks;
#endif
using VindiSharp.Core.Enums;
using VindiSharp.Core.Exceptions;
using VindiSharp.Core.Interfaces;
using RestRequest = RestSharp.RestRequest;
using NewtonsoftJsonSerializer = RestSharp.Serializers.JsonSerializer;
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


        private static void SetSerializer(IRestRequest request)
        {

            request.JsonSerializer = new NewtonsoftJsonSerializer();

        }

        private static void AddParameters(Dictionary<string, object> Parameters, IRestRequest request)
        {
            if (Parameters != null)
            {
                foreach (KeyValuePair<string, object> parameter in Parameters)
                {
                    request.AddParameter(parameter.Key, parameter.Value);
                }
            }
        }


#if NET35
        public TResponse Do<TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod, Dictionary<string, object> Parameters)
      where TResponse : class, new()
        {
            RestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            request.RequestFormat = DataFormat.Json;
            request.RootElement = NodeName;
            SetSerializer(request);

            AddParameters(Parameters, request);

            IRestResponse<TResponse> response = restClient.Execute<TResponse>(request);

            HandleResponse(response, request);

            return response.Data;
        }
        public TResponse Do<TEntity, TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod, TEntity Parameters)
            where TResponse : class, new()
            where TEntity : class, IVindiEntity, new()
        {
            RestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);

            request.RequestFormat = DataFormat.Json;
            request.RootElement = NodeName;

            request.AddJsonBody(Parameters);

            IRestResponse<TResponse> response = restClient.Execute<TResponse>(request);

            HandleResponse(response, request);

            return response.Data;
        }
        public void Do<TEntity>(string Resource, VindiRequestMethod RequestMethod, TEntity Parameters)
           where TEntity : class, IVindiEntity, new()
        {
            RestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(Parameters);

            IRestResponse response = restClient.Execute(request);

            HandleResponse(response, request);

        }
#endif
#if !NET35
        public TResponse Do<TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, Dictionary<string, object> Parameters = null)
        where TResponse : class, new()
        {
            RestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            request.RequestFormat = DataFormat.Json;
            request.RootElement = NodeName;
            SetSerializer(request);

            AddParameters(Parameters, request);

            IRestResponse<TResponse> response = restClient.Execute<TResponse>(request);

            HandleResponse(response, request);

            return response.Data;
        }
        public TResponse Do<TEntity, TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod, TEntity Parameters)
            where TResponse : class, new()
            where TEntity : class, IVindiEntity, new()
        {
            RestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);

            request.RequestFormat = DataFormat.Json;
            request.RootElement = NodeName;

            request.AddJsonBody(Parameters);

            IRestResponse<TResponse> response = restClient.Execute<TResponse>(request);

            HandleResponse(response, request);

            return response.Data;
        }
        public void Do<TEntity>(string Resource, VindiRequestMethod RequestMethod, TEntity Parameters)
           where TEntity : class, IVindiEntity, new()
        {
            RestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(Parameters);

            IRestResponse response = restClient.Execute(request);

            HandleResponse(response, request);

        }
        public async Task<TResponse> DoAsync<TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod = VindiRequestMethod.Get, Dictionary<string, object> Parameters = null)
     where TResponse : class, new()
        {
            IRestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);

            request.RequestFormat = DataFormat.Json;

            request.RootElement = NodeName;

            AddParameters(Parameters, request);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IRestResponse<TResponse> response = await restClient.ExecuteTaskAsync<TResponse>(request, cancellationTokenSource.Token);

            HandleResponse(response, request);

            return response.Data;
        }

        public async Task DoAsync<TEntity>(string Resource, VindiRequestMethod RequestMethod, TEntity Parameter)

             where TEntity : class, IVindiEntity, new()
        {
            IRestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);

            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(Parameter);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IRestResponse response = await restClient.ExecuteTaskAsync(request, cancellationTokenSource.Token);

            HandleResponse(response, request);
        }

        public async Task<TResponse> DoAsync<TEntity, TResponse>(string Resource, string NodeName, VindiRequestMethod RequestMethod, TEntity Parameter)
            where TResponse : class, new()
            where TEntity : class, IVindiEntity, new()
        {
            IRestRequest request = new RestRequest(Resource, GetMethod(RequestMethod));
            SetSerializer(request);

            request.RequestFormat = DataFormat.Json;

            request.RootElement = NodeName;

            request.AddJsonBody(Parameter);

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IRestResponse<TResponse> response = await restClient.ExecuteTaskAsync<TResponse>(request, cancellationTokenSource.Token);

            HandleResponse(response, request);

            return response.Data;
        }
#endif
        private void HandleResponse(IRestResponse response, IRestRequest request)
        {
            Int32 httpStatusCode = (int)response.StatusCode;


            if (httpStatusCode >= 400 && httpStatusCode < 500)
            {
                if (httpStatusCode == 404)
                {
                    JObject jsonObject = JObject.Parse(response.Content);
                    List<VindiError> errors = jsonObject.SelectToken("errors", false).ToObject<List<VindiError>>();

                    throw new VindiNotFoundException(errors, "O objeto requisitado não foi encontrado no Vindi, verifique a propriedade Errors da Exceção para mais detalhes");
                }
                else if (httpStatusCode == 400)
                {
                    Parameter param = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.RequestBody);

                    throw new VindiRequestInvalidSyntaxException(param != null ? param.Value.ToString() : string.Empty, "Um ou mais erros de sintaxe foram encontrados no corpo da requisição");
                }
                else if (httpStatusCode == 422)
                {
                    JObject jsonObject = JObject.Parse(response.Content);
                    List<VindiError> errors = jsonObject.SelectToken("errors", false).ToObject<List<VindiError>>();

                    throw new VindiInvalidParametersException(errors, "A requisição foi enviada com um ou mais parâmetros inválidos, verifique a propriedade Errors para mais detalhes");

                }
            }
            else if (httpStatusCode >= 500)
            {
                throw new VindiServerErrorException("A API do Vindi retornou erro 500, tente conectar novamente em alguns instantes.");
            }
        }
    }
}
