using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class WineTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;
    }
}
