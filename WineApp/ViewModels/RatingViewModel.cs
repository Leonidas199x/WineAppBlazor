using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class RatingViewModel
    {
        public int Id { get; set; }

        [Required]
        public int DrinkerId { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
