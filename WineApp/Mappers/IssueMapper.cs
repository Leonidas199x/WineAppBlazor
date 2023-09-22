using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public static class IssueMapper
    {
        public static IssueViewModel Map(Issue value)
        {
            return new IssueViewModel
            {
                Id = value.Id,
                WineId = value.WineId,
                Date = value.Date,
                Quantity = value.Quantity,
                Note = value.Note,
            };
        }

        public static Issue Map(IssueViewModel value)
        {
            return new Issue
            {
                Id = value.Id,
                WineId = value.WineId,
                Date = value.Date,
                Quantity = value.Quantity,
                Note = value.Note,
            };
        }
    }
}
