using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.QualityControl
{
    public class QualityControlService : IQualityControlService
    {
        private readonly string _endpoint = "QualityControl";
        private readonly IHttpRequestHandler _request;

        public QualityControlService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.QualityControl>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.QualityControl>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<DataContract.QualityControl>>>> Search(string name, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<DataContract.QualityControl>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.QualityControl>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.QualityControl>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Put(DataContract.QualityControl qualityControl)
        {
            var json = JsonConvert.SerializeObject(qualityControl);
            return await _request
                    .PutAsync(_endpoint, json)
                    .ConfigureAwait(false);
        }

        public async Task<Result> Post(QualityControlCreate qualityControl)
        {
            var json = JsonConvert.SerializeObject(qualityControl);

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
