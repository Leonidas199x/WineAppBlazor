using Newtonsoft.Json;

namespace WineApp.Domain
{
    public class HttpRequestHandler : IHttpRequestHandler
    {
        private readonly IHttpClientFactory _httpClient;

        public HttpRequestHandler(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Result<T>> SendAsync<T>(HttpRequestMessage request, string api = ApiNames.WineApi)
        {
            var client = _httpClient.CreateClient(api);
            var response = await client.SendAsync(request).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                return await HttpResponseHandler.HandleError<T>(response).ConfigureAwait(false);
            }

            var json = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<T>(json.Result);

            return new Result<T>(data, response.IsSuccessStatusCode);
        }

        public async Task<Result> PostAsync(string url, StringContent body)
        {
            var client = _httpClient.CreateClient(ApiNames.WineApi);
            var response = await client.PostAsync(url, body).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return new Result(response.IsSuccessStatusCode);
            }

            return await HttpResponseHandler.HandleError(response).ConfigureAwait(false);
        }

        public async Task<Result> PutAsync(string url, StringContent body)
        {
            var client = _httpClient.CreateClient(ApiNames.WineApi);

            var response = await client.PutAsync(url, body).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return new Result(response.IsSuccessStatusCode);
            }

            return await HttpResponseHandler.HandleError(response).ConfigureAwait(false);
        }

        public async Task<Result> DeleteAsync(string url)
        {
            var client = _httpClient.CreateClient(ApiNames.WineApi);

            var response = await client.DeleteAsync(url).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return new Result(response.IsSuccessStatusCode);
            }

            return await HttpResponseHandler.HandleError(response).ConfigureAwait(false);
        }
    }
}