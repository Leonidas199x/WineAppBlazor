using WineApp.ViewModels;
using DataContract;

namespace WineApp.Mappers
{
    public class CountryMapper : ICountryMapper
    {
        public CountryViewModel Map(Country value)
        {
            return new CountryViewModel
            {
                Id = value.Id,
                Name = value.Name,
                IsoCode = value.IsoCode,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
                Note = value.Note,
            };
        }

        public Country Map(CountryViewModel value) 
        {
            return new Country
            {
                Id = value.Id.Value,
                Name = value.Name,
                IsoCode = value.IsoCode,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
                Note = value.Note,
            };
        }

        public CountryInbound MapNew(CountryViewModel value)
        {
            return new CountryInbound
            {
                Name = value.Name,
                IsoCode = value.IsoCode,
                Note = value.Note,
            };
        }
    }
}
