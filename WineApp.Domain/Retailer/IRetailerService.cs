using DataContract;

namespace WineApp.Domain.Retailer
{
    public interface IRetailerService
    {
        Task<Result<PagedList<IEnumerable<DataContract.Retailer>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.Retailer>>>> Search(string colour, int page, int pageSize);

        Task<Result<DataContract.Retailer>> Get(int id);

        Task<Result> Put(DataContract.Retailer retailer);

        Task<Result> Post(RetailerCreate retailer);

        Task<Result> Delete(int id);
    }
}