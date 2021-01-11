using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Main.Shared.Api
{
    public class HttpCommunicator
    {

        private Action<ApiSucces> OnSucces { get;  }
        private Action<ApiError> OnError { get; }
        private HttpClient _httpClient;

        public HttpCommunicator(HttpClient httpClient, Action<ApiError> onError, Action<ApiSucces> onSucces)
        {
            _httpClient = httpClient;
            OnError = onError;
            OnSucces = onSucces;
        }

        public async Task<ApiOutput<T>>ProcessApi<T>(string url, HttpMethod method, object input, ApiSucces succesModel = default)
        {

            var jsonStr = JsonConvert.SerializeObject(input);
            var content = new StringContent(jsonStr, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            if (method == HttpMethod.Post)
            {
                response = await _httpClient.PostAsync(url, content);
            }
            else if (method == HttpMethod.Put)
            {
                response = await _httpClient.PutAsync(url, content);
            }
            else if (method == HttpMethod.Get)
            {
                url = SetParamsToUrl(url, input);
                response = await _httpClient.GetAsync(url);
            }
            else if (method == HttpMethod.Delete)
            {
                url = SetParamsToUrl(url, input);
                response = await _httpClient.DeleteAsync(url);
            }

            var outputString = await response.Content.ReadAsStringAsync();
            var output = JsonConvert.DeserializeObject<ApiOutput<T>>(outputString, new JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });

            if (output == null)
            {
                var error = new ApiError()
                {
                    Message = "Service unvaliable",
                    StatusCode = System.Net.HttpStatusCode.ServiceUnavailable
                };
                if (OnError != null)
                    OnError.Invoke(error);
            }
            else if (!response.IsSuccessStatusCode)
            {
                if (OnError != null)
                {
                    output.Error.StatusCode = response.StatusCode;
                    OnError.Invoke(output.Error);

                }
            }
            else
            {
                if (OnSucces != null)
                {
                    OnSucces.Invoke(succesModel);
                }
            }

            return output;
        }


        private string SetParamsToUrl(string url, object input)
        {
            if (input != null)
            {
                url += "?";
                foreach (var item in input.GetType().GetProperties())
                {
                    if (item.GetValue(input) == null)
                        continue;
                    url += $"{item.Name}={item.GetValue(input).ToString()}&";
                }

            }
            return url;
        }


    }
}
