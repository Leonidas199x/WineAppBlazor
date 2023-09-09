using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IDrinkerMapper
    {
        Drinker Map(DrinkerViewModel value);

        DrinkerViewModel Map(Drinker value);

        DrinkerCreate MapNew(DrinkerViewModel value);
    }
}