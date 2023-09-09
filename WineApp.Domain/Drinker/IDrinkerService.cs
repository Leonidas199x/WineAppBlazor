using DataContract;

namespace WineApp.Domain.Drinker
{
    public interface IDrinkerService
    {
        public Task<Result<PagedList<IEnumerable<DataContract.Drinker>>>> GetAll(int page, int pageSize);

        public Task<Result<PagedList<IEnumerable<DataContract.Drinker>>>> Search(string name, int page, int pageSize);

        public Task<Result<DataContract.Drinker>> Get(int id);

        Task<Result> Put(DataContract.Drinker drinker);

        Task<Result> Post(DrinkerCreate country);

        Task<Result> Delete(int drinkerId);
    }
}