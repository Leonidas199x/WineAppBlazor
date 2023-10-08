using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class RegionMapper : IRegionMapper
    {
        private ICountryMapper _countryMapper;

        public RegionMapper(ICountryMapper countryMapper)
        {
            _countryMapper = countryMapper;
        }

        public Region Map(RegionViewModel value)
        {
            return new Region
            {
                Id = value.Id,
                Name = value.Name,
                IsoCode = value.IsoCode,
                Note = value.Note,
                Longitude = value.Longitude,
                Latitude = value.Latitude,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
                Country = _countryMapper.Map(value.Country),
            };
        }

        public RegionViewModel Map(Region value)
        {
            return new RegionViewModel
            {
                Id = value.Id,
                Name = value.Name,
                IsoCode = value.IsoCode,
                Note = value.Note,
                Longitude = value.Longitude,
                Latitude = value.Latitude,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
                Country = _countryMapper.Map(value.Country),
            };
        }

        public RegionCreate MapNew(RegionViewModel value)
        {
            return new RegionCreate
            {
                Name = value.Name,
                IsoCode = value.IsoCode,
                Note = value.Note,
                Longitude = value.Longitude,
                Latitude = value.Latitude,
                CountryId = value.Country.Id.Value,
            };
        }
    }
}
