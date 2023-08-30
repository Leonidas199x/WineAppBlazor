using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.StopperType
{
    public class StopperTypeService : IStopperTypeService
    {
        private readonly string _endpoint = "StopperType";
        private readonly IHttpRequestHandler _request;

        public StopperTypeService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.StopperType>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.StopperType>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.StopperType>>>> Search(string colour, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={colour}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.StopperType>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.StopperType>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.StopperType>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.StopperType stopperType)
        {
            var json = JsonConvert.SerializeObject(stopperType);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(StopperTypeCreate stopperType)
        {
            var json = JsonConvert.SerializeObject(stopperType);

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
