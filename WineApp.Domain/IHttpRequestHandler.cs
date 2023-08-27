namespace WineApp.Domain
{
    public interface IHttpRequestHandler
    {
        Task<Result<T>> SendAsync<T>(HttpRequestMessage request, string api = ApiNames.WineApi);

        Task<Result> PostAsync(string url, StringContent body);

        Task<Result> PutAsync(string url, StringContent body);

        Task<Result> DeleteAsync(string url);
    }
}