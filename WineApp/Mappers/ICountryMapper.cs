using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface ICountryMapper
    {
        CountryViewModel Map(Country value);

        Country Map(CountryViewModel value);

        CountryInbound MapNew(CountryViewModel value);
    }
}