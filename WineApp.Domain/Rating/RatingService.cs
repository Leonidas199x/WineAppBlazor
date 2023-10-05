using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.Rating
{
    public class RatingService : IRatingService
    {
        private readonly string _endpoint = "Rating";
        private readonly IHttpRequestHandler _request;

        public RatingService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<IEnumerable<WineRating>>> GetByWineId(int wineId)
        {
            var url = $"{_endpoint}/WineId/{wineId}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                            .SendAsync<IEnumerable<WineRating>>(request)
                            .ConfigureAwait(false);
        }
    }
}
