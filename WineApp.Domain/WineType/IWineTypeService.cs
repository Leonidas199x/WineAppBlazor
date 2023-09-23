using DataContract;

namespace WineApp.Domain.WineType
{
    public interface IWineTypeService
    {
        Task<Result<PagedList<IEnumerable<DataContract.WineType>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.WineType>>>> Search(string name, int page, int pageSize);

        Task<Result<DataContract.WineType>> Get(int id);

        Task<Result<IEnumerable<WineTypeLookup>>> GetLookup();

        Task<Result> Put(DataContract.WineType vineywarEstate);

        Task<Result> Post(WineTypeCreate vineyardEstate);

        Task<Result> Delete(int id);
    }
}