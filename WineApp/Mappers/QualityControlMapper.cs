using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class QualityControlMapper : IQualityControlMapper
    {
        private readonly ICountryMapper _countryMapper;

        public QualityControlMapper(ICountryMapper countryMapper)
        {
            _countryMapper = countryMapper;
        }

        public QualityControl Map(QualityControlViewModel value)
        {
            return new QualityControl
            {
                Id = value.Id,
                Name = value.Name,
                Country = _countryMapper.Map(value.Country),
                Note = value.Note,
            };
        }

        public QualityControlViewModel Map(QualityControl value)
        {
            return new QualityControlViewModel
            {
                Id = value.Id,
                Name = value.Name,
                Country = _countryMapper.Map(value.Country),
                Note = value.Note,
            };
        }

        public QualityControlCreate MapNew(QualityControlViewModel value)
        {
            return new QualityControlCreate
            {
                Name = value.Name,
                Note = value.Note,
                CountryId = value.Country.Id,
            };
        }
    }
}
