using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class QualityControlViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        public CountryViewModel Country { get; set; } = new CountryViewModel();
    }
}
