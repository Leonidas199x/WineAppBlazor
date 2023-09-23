using DataContract;

namespace WineApp.Domain.VineyardEstate
{
    public interface IVineyardEstateService
    {
        Task<Result<PagedList<IEnumerable<DataContract.VineyardEstate>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.VineyardEstate>>>> Search(string name, int page, int pageSize);

        Task<Result<IEnumerable<VineyardEstateLookup>>> GetLookup();

        Task<Result<DataContract.VineyardEstate>> Get(int id);

        Task<Result> Put(DataContract.VineyardEstate vineywarEstate);

        Task<Result> Post(VineyardEstateCreate vineyardEstate);

        Task<Result> Delete(int id);
    }
}