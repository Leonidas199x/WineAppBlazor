using DataContract;

namespace WineApp.Domain.Countries
{
    public interface ICountryService
    {
        public Task<Result<PagedList<IEnumerable<Country>>>> GetAll(int page, int pageSize);

        public Task<Result<Country>> Get(int id);
    }
}