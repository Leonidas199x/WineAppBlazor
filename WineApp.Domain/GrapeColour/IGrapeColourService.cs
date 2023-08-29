using DataContract;

namespace WineApp.Domain.GrapeColour
{
    public interface IGrapeColourService
    {
        Task<Result<PagedList<IEnumerable<DataContract.GrapeColour>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.GrapeColour>>>> Search(string colour, int page, int pageSize);

        Task<Result<DataContract.GrapeColour>> Get(int id);

        Task<Result> Put(DataContract.GrapeColour grapeColour);

        Task<Result> Post(DataContract.GrapeColour grapeColour);

        Task<Result> Delete(int id);
    }
}