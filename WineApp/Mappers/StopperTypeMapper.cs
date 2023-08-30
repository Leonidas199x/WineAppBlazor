using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class StopperTypeMapper : IStopperTypeMapper
    {
        public StopperType Map(StopperTypeViewModel value)
        {
            return new StopperType
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public StopperTypeViewModel Map(StopperType value)
        {
            return new StopperTypeViewModel
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public StopperTypeCreate MapNew(StopperTypeViewModel value)
        {
            return new StopperTypeCreate
            {
                Name = value.Name,
            };
        }
    }
}
