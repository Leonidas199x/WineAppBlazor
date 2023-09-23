using DataContract;

namespace WineApp.Domain.Producer
{
    public class ProducerService : IProducerService
    {
        private readonly string _endpoint = "Producer";
        private readonly IHttpRequestHandler _request;

        public ProducerService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<IEnumerable<ProducerLookup>>> GetLookup()
        {
            var url = $"{_endpoint}/Lookup";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var producers = await _request
                .SendAsync<IEnumerable<ProducerLookup>>(request)
                .ConfigureAwait(false);

            producers.Data = producers.Data.ToList();

            return producers;
        }
    }
}
