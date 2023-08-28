namespace WineApp.Domain
{
    public interface IHttpRequestHandler
    {
        Task<Result<T>> SendAsync<T>(HttpRequestMessage request, string api = ApiNames.WineApi);

        Task<Result> PostAsync(string url, string body);

        Task<Result> PutAsync(string url, string body);

        Task<Result> DeleteAsync(string url);
    }
}