namespace WineApp.Domain.Issue
{
    public interface IIssueService
    {
        Task<Result<IEnumerable<DataContract.Issue>>> GetByWineId(int wineId);

        Task<Result> Put(DataContract.Issue issue);

        Task<Result> Post(DataContract.Issue issue);

        Task<Result> Delete(int id);
    }
}