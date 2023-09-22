using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class IssueViewModel
    {
        public int Id { get; set; }

        [Required]
        public int WineId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int Quantity { get; set; }

        public string Note { get; set; } = string.Empty;
    }
}
