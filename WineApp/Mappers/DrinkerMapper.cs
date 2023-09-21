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

        public static IEnumerable<DrinkerSelect> Map(IEnumerable<Drinker> value)
        {
            return value.Select(x => MapSelect(x));
        }

        public static DrinkerSelect MapSelect(Drinker value)
        {
            return new DrinkerSelect
            {
                Id = (value.Id == 0) ? null : value.Id,
                Name = value.Name,
            };
        }
    }
}
