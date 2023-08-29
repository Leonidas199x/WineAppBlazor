using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class GrapeColourViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Colour { get; set; } = string.Empty;
    }
}
