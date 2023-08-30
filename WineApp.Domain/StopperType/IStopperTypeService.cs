using DataContract;

namespace WineApp.Domain.StopperType
{
    public interface IStopperTypeService
    {
        Task<Result<PagedList<IEnumerable<DataContract.StopperType>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.StopperType>>>> Search(string colour, int page, int pageSize);

        Task<Result<DataContract.StopperType>> Get(int id);

        Task<Result> Put(DataContract.StopperType grapeColour);

        Task<Result> Post(StopperTypeCreate grapeColour);

        Task<Result> Delete(int id);
    }
}