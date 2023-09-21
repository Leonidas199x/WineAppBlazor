using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public static class RatingMapper
    {
        public static RatingViewModel Map(WineRating value)
        {
            return new RatingViewModel
            {
                Id = value.Id,
                DrinkerId = value.Drinker.Id,
                WineId = value.WineId,
                Rating = value.Rating
            };
        }

        public static WineRating Map(RatingViewModel value)
        {
            return new WineRating
            {
                Id = value.Id,
                WineId = value.WineId,
                Rating = value.Rating,
                Drinker = new Drinker
                {
                    Id = value.DrinkerId,
                },
            };
        }
    }
}
