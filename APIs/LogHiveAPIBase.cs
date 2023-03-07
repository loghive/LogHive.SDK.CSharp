using LogHive.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LogHive.SDK.CSharp.APIs
{
    internal abstract class LogHiveAPIBase : IDisposable
    {
        protected readonly string _apiToken;
        protected readonly string _url = @"https://api.loghive.app/v1/";
        private readonly HttpClient _httpClient;

        public LogHiveAPIBase(string apiToken, string url = "")
        {
            _apiToken = apiToken;

            if (url != "" && url.Length > 0)
                _url = url.Substring(url.Length - 1, 1) == "/" ? url : $"{url}/";

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("ApiKey", apiToken);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }

        public async Task<EventPushFeedbackDto> PostAsync(string url, object data)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(url, data);
                if (!response.IsSuccessStatusCode)
                {
                    return new EventPushFeedbackDto()
                    {
                        Error = true,
                        ErrorMessage = await response.Content.ReadAsStringAsync(),
                        ResponseCode = (int)response.StatusCode
                    };
                }

                var content = await response.Content.ReadAsStringAsync();
                return new EventPushFeedbackDto()
                {
                    Error = false,
                    ErrorMessage = await response.Content.ReadAsStringAsync(),
                    ResponseCode = (int)response.StatusCode
                };
            }
            catch (Exception ex)
            {
                return new EventPushFeedbackDto()
                {
                    Error = true,
                    ErrorMessage = ex.Message,
                    ResponseCode = 400
                };
            }
        }
    }
}