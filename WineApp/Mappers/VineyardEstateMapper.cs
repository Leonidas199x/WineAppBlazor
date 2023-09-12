using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class VineyardEstateMapper : IVineyardEstateMapper
    {
        public VineyardEstate Map(VineyardEstateViewModel value)
        {
            return new VineyardEstate
            {
                Id = value.Id,
                Name = value.Name,
                Note = value.Note,
                Longitude = value.Longitude,
                Latitude = value.Latitude,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
            };
        }

        public VineyardEstateViewModel Map(VineyardEstate value)
        {
            return new VineyardEstateViewModel
            {
                Id = value.Id,
                Name = value.Name,
                Note = value.Note,
                Longitude = value.Longitude,
                Latitude = value.Latitude,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
            };
        }

        public VineyardEstateCreate MapNew(VineyardEstateViewModel value)
        {
            return new VineyardEstateCreate
            {
                Name = value.Name,
                Note = value.Note,
                Longitude = value.Longitude,
                Latitude = value.Latitude,
            };
        }
    }
}
