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

        public async Task<Result> Put(WineRating rating)
        {
            var json = JsonConvert.SerializeObject(rating);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(WineRating rating)
        {
            var json = JsonConvert.SerializeObject(rating);

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
