﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WineApp.ViewModels
{
    public class RetailerViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Minimum Purchase Quantity")]
        public int? MinimumPurchaseQuantity { get; set; }

        [DisplayName("Increment Quantity")]
        public int? IncrementQuantity { get; set; }

        [DisplayName("Generic Discount %")]
        public decimal? GenericDiscountPercentage { get; set; }

        [DisplayName("Generic Discount Name")]
        public string GenericDiscountName { get; set; } = string.Empty;

        [DisplayName("Website")]
        public Uri WebsiteUrl { get; set; }

        [DisplayName("Website Rating")]
        public int? WebsiteRating { get; set; }

        [DisplayName("Order Rating")]
        public int? OrderRating { get; set; }

        [DisplayName("Delivery Rating")]
        public int? DeliveryRating { get; set; }

        [DisplayName("Max Customer Rating")]
        public int? MaxCustomerRating { get; set; }

        [DisplayName("Name")]
        public string Note { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}
