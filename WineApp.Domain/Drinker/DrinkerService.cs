using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.Drinker
{
    public class DrinkerService : IDrinkerService
    {
        private readonly string _endpoint = "Drinker";
        private readonly IHttpRequestHandler _request;

        public DrinkerService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.Drinker>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.Drinker>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.Drinker>>>> Search(string name, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.Drinker>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.Drinker>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.Drinker>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.Drinker drinker)
        {
            var json = JsonConvert.SerializeObject(drinker);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(DrinkerCreate drinker)
        {
            var json = JsonConvert.SerializeObject(drinker);

            return await _request
                    .PostAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Delete(int id)
        {
            var url = $"{_endpoint}/{id}";

            return await _request
                        .DeleteAsync(url)
                        .ConfigureAwait(false);
        }
    }
}
