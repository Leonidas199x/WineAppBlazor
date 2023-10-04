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
                RegionId = value.Region.Id,
                QualityControlId = value.QualityControl?.Id,
                VineyardEstateId = value.VineyardEstate?.Id,
                WineTypeId = value.WineType.Id,
            };
        }

        public static DataContract.WineCreate Map(WineViewModel value)
        {
            return new DataContract.WineCreate
            {
                Description = value.Description,
                Importer = value.Importer,
                Abv = value.Abv,
                ProducerId = value.ProducerId,
                RegionId = value.RegionId.Value,
                VineyardEstateId = value.VineyardEstateId,
                Vintage = value.Vintage,
                QualityControlId = value.QualityControlId,
                WineTypeId = value.WineTypeId.Value,
                InventoryLevel = value.InventoryLevel,
                ExclusiveToRetailerId = value.ExclusiveRetailerId,
            };
        }
    }
}
