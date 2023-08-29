using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.GrapeColour
{
    public class GrapeColourService : IGrapeColourService
    {
        private readonly string _endpoint = "GrapeColour";
        private readonly IHttpRequestHandler _request;

        public GrapeColourService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.GrapeColour>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.GrapeColour>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.GrapeColour>>>> Search(string colour, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={colour}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.GrapeColour>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.GrapeColour>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.GrapeColour>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.GrapeColour grapeColour)
        {
            var json = JsonConvert.SerializeObject(grapeColour);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(DataContract.GrapeColour grapeColour)
        {
            var json = JsonConvert.SerializeObject(grapeColour);

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
