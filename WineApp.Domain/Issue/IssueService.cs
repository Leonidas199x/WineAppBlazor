using Newtonsoft.Json;


namespace WineApp.Domain.Issue
{
    public class IssueService : IIssueService
    {
        private readonly string _endpoint = "Issue";
        private readonly IHttpRequestHandler _request;

        public IssueService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<IEnumerable<DataContract.Issue>>> GetByWineId(int wineId)
        {
            var url = $"{_endpoint}/WineId/{wineId}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                            .SendAsync<IEnumerable<DataContract.Issue>>(request)
                            .ConfigureAwait(false);
        }
    }
}
