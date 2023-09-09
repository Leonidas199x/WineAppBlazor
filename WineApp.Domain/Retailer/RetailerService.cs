using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.Retailer
{
    public class RetailerService : IRetailerService
    {
        private readonly string _endpoint = "Retailer";
        private readonly IHttpRequestHandler _request;

        public RetailerService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.Retailer>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.Retailer>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.Retailer>>>> Search(string colour, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={colour}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.Retailer>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.Retailer>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.Retailer>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.Retailer retailer)
        {
            var json = JsonConvert.SerializeObject(retailer);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(RetailerCreate retailer)
        {
            var json = JsonConvert.SerializeObject(retailer);

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
