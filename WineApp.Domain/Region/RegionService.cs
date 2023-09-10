using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.Region
{
    public class RegionService : IRegionService
    {
        private readonly string _endpoint = "Region";
        private readonly IHttpRequestHandler _request;

        public RegionService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.Region>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.Region>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.Region>>>> Search(string name, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.Region>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.Region>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.Region>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.Region region)
        {
            var json = JsonConvert.SerializeObject(region);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(RegionCreate region)
        {
            var json = JsonConvert.SerializeObject(region);

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
