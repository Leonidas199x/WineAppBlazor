using DataContract;

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

        public async Task<Result<Country>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<Country>(request)
                .ConfigureAwait(false);
        }
    }
}
