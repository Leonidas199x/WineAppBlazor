using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class CountryViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "ISO Code is required")]
        public string IsoCode { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
