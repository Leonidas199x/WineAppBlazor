using DataContract;

namespace WineApp.Domain.Rating
{
    public interface IRatingService
    {
        Task<Result<IEnumerable<WineRating>>> GetByWineId(int wineId);
    }
}