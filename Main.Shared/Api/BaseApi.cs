using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Main.Shared.Api
{

    public interface IBaseApi
    {
        HttpClient HttpClient { get; }
        Action<ApiError> OnError { get; set; }
        Action<ApiSucces> OnSucces { get; set; }
        Task<ApiOutput<AuthenticationOutput>> Authenticate(AuthenticationInput input);
    }


    public class BaseApi : IBaseApi
    {
        public HttpClient HttpClient => _httpClient;

        public bool SimulateApiRequest { get; set; } = false;

        public Action<ApiError> OnError { get; set; }
        public Action<ApiSucces> OnSucces { get; set; }

        private HttpClient _httpClient;
        private HttpCommunicator _httpCommunicator;

        public BaseApi(string baseAddress)
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseAddress)
            };
            Init(_httpClient);
        }

        public BaseApi(HttpClient httpClient)
        {
            Init(httpClient);
        }


        public async Task<ApiOutput<AuthenticationOutput>> Authenticate(AuthenticationInput input)
        {

            var output = await _httpCommunicator.ProcessApi<AuthenticationOutput>(
                "api/TokenAuth/Authenticate", HttpMethod.Post, input);

            if (output.Success)
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", output.Result.AccessToken);
            }

            return output;
        }

        private void Init(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpCommunicator = new HttpCommunicator(_httpClient, OnError, OnSucces);
        }
    }
}
