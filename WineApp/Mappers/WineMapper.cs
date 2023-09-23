using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public static class WineMapper
    {
        public static WineViewModel Map(DataContract.Wine value)
        {
            return new WineViewModel
            {
                Id = value.Id,
                Description = value.Description,
                Vintage = value.Vintage,
                Abv = value.Abv,
                Importer = value.Importer,
                InventoryLevel = value.InventoryLevel,
                ExclusiveRetailerId = value.ExclusiveRetailer?.Id,
                ProducerId = value.Producer?.Id,
                RegionId = value.Region?.Id,
                QualityControlId = value.QualityControl?.Id,
                VineyardEstateId = value.VineyardEstate?.Id,
                WineTypeId = value.WineType?.Id,
            };
        }
    }
}
