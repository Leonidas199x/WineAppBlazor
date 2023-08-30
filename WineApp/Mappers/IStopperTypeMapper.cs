using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IStopperTypeMapper
    {
        StopperType Map(StopperTypeViewModel value);

        StopperTypeViewModel Map(StopperType value);

        StopperTypeCreate MapNew(StopperTypeViewModel value);
    }
}