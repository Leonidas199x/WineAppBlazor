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

        public async Task<Result> Put(DataContract.Issue issue)
        {
            var json = JsonConvert.SerializeObject(issue);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(DataContract.Issue issue)
        {
            var json = JsonConvert.SerializeObject(issue);

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
