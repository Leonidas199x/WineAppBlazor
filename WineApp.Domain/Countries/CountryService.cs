using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.Countries
{
    public class CountryService : ICountryService
    {
        private readonly string _endpoint = "Country";
        private readonly IHttpRequestHandler _request;

        public CountryService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<Country>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<Country>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<Country>>>> Search(string name, string isoCode, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&isoCode={isoCode}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<Country>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<Country>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<Country>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(Country country)
        {
            var json = JsonConvert.SerializeObject(country);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(CountryInbound country)
        {
            var json = JsonConvert.SerializeObject(country);

            return await _request
                    .PostAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Delete(int countryId)
        {
            var url = $"{_endpoint}/{countryId}";

            return await _request
                        .DeleteAsync(url) 
                        .ConfigureAwait(false);
        }
    }
}
