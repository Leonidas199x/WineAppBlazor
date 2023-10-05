namespace WineApp.Domain.Issue
{
    public interface IIssueService
    {
        Task<Result<IEnumerable<DataContract.Issue>>> GetByWineId(int wineId);
    }
}