using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IVineyardEstateMapper
    {
        VineyardEstate Map(VineyardEstateViewModel value);

        VineyardEstateViewModel Map(VineyardEstate value);

        VineyardEstateCreate MapNew(VineyardEstateViewModel value);
    }
}