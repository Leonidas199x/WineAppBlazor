using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class StopperTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
