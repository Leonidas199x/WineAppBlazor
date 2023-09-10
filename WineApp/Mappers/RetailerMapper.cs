using DataContract;
using WineApp.ViewModels;

namespace WineApp.Mappers
{
    public class RetailerMapper : IRetailerMapper
    {
        public Retailer Map(RetailerViewModel value)
        {
            return new Retailer
            {
                Id = value.Id,
                Name = value.Name,
                MinimumPurchaseQuantity = value.MinimumPurchaseQuantity,
                IncrementQuantity = value.IncrementQuantity,
                GenericDiscountPercentage = value.GenericDiscountPercentage,
                GenericDiscountName = value.GenericDiscountName,
                WebsiteUrl = value.WebsiteUrl,
                WebsiteRating = value.WebsiteRating,
                OrderRating = value.OrderRating,
                DeliveryRating = value.DeliveryRating,
                MaxCustomerRating = value.MaxCustomerRating,
                Note = value.Note,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
            };
        }

        public RetailerViewModel Map(Retailer value)
        {
            return new RetailerViewModel
            {
                Id = value.Id,
                Name = value.Name,
                MinimumPurchaseQuantity = value.MinimumPurchaseQuantity,
                IncrementQuantity = value.IncrementQuantity,
                GenericDiscountPercentage = value.GenericDiscountPercentage,
                GenericDiscountName = value.GenericDiscountName,
                WebsiteUrl = value.WebsiteUrl,
                WebsiteRating = value.WebsiteRating,
                OrderRating = value.OrderRating,
                DeliveryRating = value.DeliveryRating,
                MaxCustomerRating = value.MaxCustomerRating,
                Note = value.Note,
                DateCreated = value.DateCreated,
                DateUpdated = value.DateUpdated,
            };
        }

        public RetailerCreate MapNew(RetailerViewModel value)
        {
            return new RetailerCreate
            {
                Name = value.Name,
                MinimumPurchaseQuantity = value.MinimumPurchaseQuantity,
                IncrementQuantity = value.IncrementQuantity,
                GenericDiscountPercentage = value.GenericDiscountPercentage,
                GenericDiscountName = value.GenericDiscountName,
                WebsiteUrl = value.WebsiteUrl,
                WebsiteRating = value.WebsiteRating,
                OrderRating = value.OrderRating,
                DeliveryRating = value.DeliveryRating,
                MaxCustomerRating = value.MaxCustomerRating,
                Note = value.Note,
            };
        }
    }
}
