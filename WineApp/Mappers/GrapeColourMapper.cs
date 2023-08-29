using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class GrapeColourMapper : IGrapeColourMapper
    {
        public GrapeColour Map(GrapeColourViewModel value)
        {
            return new GrapeColour
            {
                Id = value.Id,
                Colour = value.Colour,
            };
        }

        public GrapeColourViewModel Map(GrapeColour value)
        {
            return new GrapeColourViewModel
            {
                Id = value.Id,
                Colour = value.Colour,
            };
        }
    }
}
