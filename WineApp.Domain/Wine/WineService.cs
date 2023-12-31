﻿using DataContract;
using Newtonsoft.Json;

namespace WineApp.Domain.Wine
{
    public class WineService : IWineService
    {
        private readonly string _endpoint = "Wine";
        private readonly IHttpRequestHandler _request;

        public WineService(IHttpRequestHandler request)
        {
            _request = request;
        }

        public async Task<Result<PagedList<IEnumerable<WineHeader>>>> GetAll(int page, int pageSize)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}?page={page}&pageSize={pageSize}");

            return await _request
                .SendAsync<PagedList<IEnumerable<WineHeader>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<DataContract.Wine>> Get(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_endpoint}/{id}");

            return await _request
                .SendAsync<DataContract.Wine>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result<PagedList<IEnumerable<WineHeader>>>> Search(string name, int page, int pageSize)
        {
            var url = $"{_endpoint}/search?name={name}&page={page}&pageSize={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            return await _request
                .SendAsync<PagedList<IEnumerable<WineHeader>>>(request)
                .ConfigureAwait(false);
        }

        public async Task<Result> Post(WineCreate wine)
        {
            var json = JsonConvert.SerializeObject(wine);

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
