using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IWineTypeMapper
    {
        WineType Map(WineTypeViewModel value);

        WineTypeViewModel Map(WineType value);

        WineTypeCreate MapNew(WineTypeViewModel value);
    }
}