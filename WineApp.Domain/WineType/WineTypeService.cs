using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.WineType
{
    public class WineTypeService : IWineTypeService
    {
        private readonly string _endpoint = "WineType";
        private readonly IHttpRequestHandler _request;

        public WineTypeService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.WineType>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.WineType>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.WineType>>>> Search(string name, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.WineType>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.WineType>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.WineType>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.WineType wineType)
        {
            var json = JsonConvert.SerializeObject(wineType);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(WineTypeCreate wineType)
        {
            var json = JsonConvert.SerializeObject(wineType);

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
