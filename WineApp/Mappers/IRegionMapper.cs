using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IRegionMapper
    {
        Region Map(RegionViewModel value);

        RegionViewModel Map(Region value);

        RegionCreate MapNew(RegionViewModel value);
    }
}