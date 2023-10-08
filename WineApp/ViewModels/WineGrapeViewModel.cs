using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class WineGrapeViewModel
    {
        public int Id { get; set; }

        public int WineId { get; set; }

        [Required]
        public int GrapeId { get; set; }
    }
}
