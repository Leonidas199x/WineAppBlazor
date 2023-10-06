using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class GrapeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int? GrapeColourId { get; set; }

        public string Note { get; set; } = string.Empty;
    }
}
