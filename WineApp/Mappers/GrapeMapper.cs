using WineApp.ViewModels;
using DataContract;

namespace WineApp.Mappers
{
    public static class GrapeMapper
    {
        public static GrapeViewModel Map(Grape value)
        {
            return new GrapeViewModel
            {
                Id = value.Id,
                Name = value.Name,
                GrapeColourId = value.Colour.Id,
                Note = value.Note,
            };
        }

        public static GrapeCreate MapNew(GrapeViewModel value)
        {
            return new GrapeCreate
            {
                Name = value.Name,
                GrapeColourId = value.GrapeColourId,
                Note = value.Note,
            };
        }

        public static Grape Map(GrapeViewModel value) 
        {
            return new Grape
            {
                Id = value.Id,
                Name = value.Name,
                Colour = new GrapeColour
                {
                    Id = value.GrapeColourId.Value,
                },
                Note = value.Note,
            };
        }
    }
}
