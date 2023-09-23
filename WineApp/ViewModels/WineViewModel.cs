using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class WineViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public int? ProducerId { get; set; }

        public int? RegionId { get; set; }

        [Range(1900, 2100, ErrorMessage = "Vintage must be between 1900 & 2100")]
        public int Vintage { get; set; }

        public int? QualityControlId { get; set; }

        public int? VineyardEstateId { get; set; }

        public int? WineTypeId { get; set; }

        public decimal Abv { get; set; }

        public string Importer { get; set; } = string.Empty;

        public int InventoryLevel { get; set; }

        public int? ExclusiveRetailerId { get; set; }
    }
}
