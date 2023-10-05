using DataContract;

namespace WineApp.Domain
{
    public interface IRequestService
    {
        Task<Result<PagedList<IEnumerable<T>>>> GetAll<T>(int page, int pageSize, string endpoint);

        Task<Result<PagedList<IEnumerable<T>>>> Search<T>(Dictionary<string, string> searchParams, int page, int pageSize, string endpoint);

        Task<Result<T>> Get<T>(int id, string endpoint);

        Task<Result<IEnumerable<T>>> GetByWineId<T>(string endpoint, int wineId);

        Task<Result<IEnumerable<T>>> GetLookup<T>(string endpoint);

        Task<Result> Put<T>(T value, string endpoint);

        Task<Result> Post<T>(T value, string endpoint);

        Task<Result<T>> Post<T, X>(X value, string endpoint);

        Task<Result> Delete(int id, string endpoint);
    }
}