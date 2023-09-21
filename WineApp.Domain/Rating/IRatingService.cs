using DataContract;

namespace WineApp.Domain.Rating
{
    public interface IRatingService
    {
        Task<Result<IEnumerable<WineRating>>> GetByWineId(int wineId);

        Task<Result> Put(WineRating rating);

        Task<Result> Post(WineRating rating);

        Task<Result> Delete(int id);
    }
}