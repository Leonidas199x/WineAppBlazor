using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class DrinkerMapper : IDrinkerMapper
    {
        public DrinkerViewModel Map(Drinker value)
        {
            return new DrinkerViewModel
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public Drinker Map(DrinkerViewModel value)
        {
            return new Drinker
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public DrinkerCreate MapNew(DrinkerViewModel value)
        {
            return new DrinkerCreate
            {
                Name = value.Name,
            };
        }
    }
}
