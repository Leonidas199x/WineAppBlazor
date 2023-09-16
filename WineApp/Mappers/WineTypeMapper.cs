using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class WineTypeMapper : IWineTypeMapper
    {
        public WineType Map(WineTypeViewModel value)
        {
            return new WineType
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public WineTypeViewModel Map(WineType value)
        {
            return new WineTypeViewModel
            {
                Id = value.Id,
                Name = value.Name,
                Note = value.Note,
            };
        }

        public WineTypeCreate MapNew(WineTypeViewModel value)
        {
            return new WineTypeCreate
            {
                Name = value.Name,
                Note = value.Note,
            };
        }
    }
}
