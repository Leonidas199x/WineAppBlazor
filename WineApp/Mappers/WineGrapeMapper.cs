using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public static class WineGrapeMapper
    {
        public static WineGrape Map(WineGrapeViewModel value)
        {
            return new WineGrape
            {
                Id = value.Id,
                GrapeId = value.GrapeId,
                WineId = value.WineId,
            };
        }
    }
}
