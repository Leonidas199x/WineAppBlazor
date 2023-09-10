namespace WineApp.ViewModels
{
    public class RegionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string IsoCode { get; set; } = string.Empty;

        public CountryViewModel Country { get; set; }

        public string Note { get; set; } = string.Empty;

        public decimal? Longitude { get; set; }

        public decimal? Latitude { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
