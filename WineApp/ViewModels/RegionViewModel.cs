using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class RegionViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string IsoCode { get; set; } = string.Empty;

        [Required]
        public int? CountryId { get; set; }

        public string Note { get; set; } = string.Empty;

        public decimal? Longitude { get; set; }

        public decimal? Latitude { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
