using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.VineyardEstate
{
    public class VineyardEstateService : IVineyardEstateService
    {
        private readonly string _endpoint = "VineyardEstate";
        private readonly IHttpRequestHandler _request;

        public VineyardEstateService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.VineyardEstate>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.VineyardEstate>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.VineyardEstate>>>> Search(string name, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.VineyardEstate>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<IEnumerable<VineyardEstateLookup>>> GetLookup()
        {
            var url = $"{_endpoint}/Lookup";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var vineyardEstates = await _request
                .SendAsync<IEnumerable<VineyardEstateLookup>>(request)
                .ConfigureAwait(false);

            vineyardEstates.Data = vineyardEstates.Data.ToList();

            return vineyardEstates;
        }

        public async Task<Result<DataContract.VineyardEstate>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.VineyardEstate>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.VineyardEstate vineyardEstate)
        {
            var json = JsonConvert.SerializeObject(vineyardEstate);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(VineyardEstateCreate vineyardEstate)
        {
            var json = JsonConvert.SerializeObject(vineyardEstate);

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
