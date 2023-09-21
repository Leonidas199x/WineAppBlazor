using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public static class DrinkerMapper
    {
        public static DrinkerViewModel Map(Drinker value)
        {
            return new DrinkerViewModel
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public static Drinker Map(DrinkerViewModel value)
        {
            return new Drinker
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public static DrinkerCreate MapNew(DrinkerViewModel value)
        {
            return new DrinkerCreate
            {
                Name = value.Name,
            };
        }

        public static IEnumerable<DrinkerSelectViewModel> Map(IEnumerable<Drinker> value)
        {
            return value.Select(x => MapSelect(x));
        }

        public static DrinkerSelectViewModel MapSelect(Drinker value)
        {
            return new DrinkerSelectViewModel
            {
                Id = value.Id,
                Name = value.Name,
            };
        }
    }
}
