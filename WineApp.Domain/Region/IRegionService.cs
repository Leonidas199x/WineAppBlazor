using DataContract;

namespace WineApp.Domain.Region
{
    public interface IRegionService
    {
        Task<Result<PagedList<IEnumerable<DataContract.Region>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.Region>>>> Search(string name, int page, int pageSize);

        Task<Result<DataContract.Region>> Get(int id);

        Task<Result> Put(DataContract.Region grapeColour);

        Task<Result> Post(DataContract.Region grapeColour);

        Task<Result> Delete(int id);
    }
}