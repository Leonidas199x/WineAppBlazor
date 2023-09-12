namespace WineApp.Domain.Maps
{
    public class MapsService : IMapsService
    {
        private readonly string _apiKey;
        private readonly IHttpRequestHandler _request;

        public MapsService(string apiKey, IHttpRequestHandler request)
        {
            _apiKey = apiKey;
            _request = request;
        }

        public async Task<Result<MapInfo>> GetRegionInfo(string region)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"Locations/{region}?key={_apiKey}");

            return await _request
                .SendAsync<MapInfo>(request, ApiNames.BingMaps)
                .ConfigureAwait(false);
        }
    }
}
