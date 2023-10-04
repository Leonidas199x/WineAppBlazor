using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain
{
    public class RequestService : IRequestService
    {
        private readonly IHttpRequestHandler _request;

        public RequestService(IHttpRequestHandler request) 
        { 
            _request = request; 
        }

        public async Task<Result> Delete(int id, string endpoint)
        {
            var url = $"{endpoint}/{id}";

            return await _request
                        .DeleteAsync(url)
                        .ConfigureAwait(false);
        }

        public async Task<Result<T>> Get<T>(int id, string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{endpoint}/{id}");

            return await _request
                .SendAsync<T>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<T>>>> GetAll<T>(int page, int pageSize, string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<T>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<IEnumerable<T>>> GetLookup<T>(string endpoint)
        {
            var url = $"{endpoint}/Lookup";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var result = await _request
                .SendAsync<IEnumerable<T>>(request)
                .ConfigureAwait(false);

            result.Data = result.Data.ToList();

            return result;
        }

        public async Task<Result> Post<T>(T value, string endpoint)
        {
            var json = JsonConvert.SerializeObject(value);

            return await _request
                    .PostAsync(endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Put<T>(T value, string endpoint)
        {
            var json = JsonConvert.SerializeObject(value);
            return await _request
                    .PutAsync(endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<T>>>> Search<T>(string name, int page, int pageSize, string endpoint)
        {
            var url = $"{endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<T>>>(request)
                .ConfigureAwait(false);
        }
    }
}
