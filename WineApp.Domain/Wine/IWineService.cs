using DataContract;

namespace WineApp.Domain.Wine
{
    public interface IWineService
    {
        Task<Result<PagedList<IEnumerable<WineHeader>>>> GetAll(int page, int pageSize);

        Task<Result<DataContract.Wine>> Get(int id);

        Task<Result<PagedList<IEnumerable<WineHeader>>>> Search(string name, int page, int pageSize);

        Task<Result> Delete(int id);
    }
}