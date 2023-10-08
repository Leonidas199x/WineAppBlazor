using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class DrinkerViewModel
    { 
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
