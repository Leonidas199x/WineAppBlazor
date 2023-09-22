using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class RatingViewModel
    {
        public int Id { get; set; }

        [Required]
        public int DrinkerId { get; set; }

        [Required]
        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public int Rating { get; set; }

        public int WineId { get; set; }
    }
}
