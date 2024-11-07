using System;

namespace si730pc2u20201f846.API.WMS.Application.Internal.DTOs
{
    /// <summary>
    /// Data Transfer Object for Product.
    /// </summary>
    public class ProductDto
    {
        public Guid ProductId { get; set; } // Unique identifier for the product
        public string ProductName { get; set; } // Name of the product
        public string Sku { get; set; } // Stock Keeping Unit
        public string CategoryName { get; set; } // Name of the category associated with the product
        public int Status { get; set; } // Status of the product (e.g., Available, OutOfStock)
        public string Location { get; set; } // Location in the warehouse
        public int Quantity { get; set; } // Quantity of the product in stock
        public DateTime CreatedAt { get; set; } // Date when the product was created
        public DateTime? UpdatedAt { get; set; } // Date when the product was last updated, if applicable
    }
}
