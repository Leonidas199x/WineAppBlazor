using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public interface IGrapeColourMapper
    {
        GrapeColour Map(GrapeColourViewModel value);

        GrapeColourViewModel Map(GrapeColour value);
    }
}