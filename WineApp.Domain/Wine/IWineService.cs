using DataContract;

namespace WineApp.Domain.Wine
{
    public interface IWineService
    {
        Task<Result<PagedList<IEnumerable<DataContract.WineHeader>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<WineHeader>>>> Search(string name, int page, int pageSize);

        Task<Result> Delete(int id);
    }
}