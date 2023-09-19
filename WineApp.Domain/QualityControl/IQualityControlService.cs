using DataContract;

namespace WineApp.Domain.QualityControl
{
    public interface IQualityControlService
    {
        Task<Result<PagedList<IEnumerable<DataContract.QualityControl>>>> GetAll(int page, int pageSize);

        Task<Result<PagedList<IEnumerable<DataContract.QualityControl>>>> Search(string name, int page, int pageSize);

        Task<Result<DataContract.QualityControl>> Get(int id);

        Task<Result> Put(DataContract.QualityControl qualityControl);

        Task<Result> Post(QualityControlCreate qualityControl);

        Task<Result> Delete(int id);
    }
}