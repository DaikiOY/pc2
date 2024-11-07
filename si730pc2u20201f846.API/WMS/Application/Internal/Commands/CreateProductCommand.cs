using System;
using si730pc2u20201f846.API.WMS.Application.Internal.DTOs;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Commands
{
    /// <summary>
    /// Command to create a new product.
    /// </summary>
    public class CreateProductCommand
    {
        public string ProductName { get; set; } 
        public string Sku { get; set; } 
        public int CategoryId { get; set; }
        public int Status { get; set; } = 1; 
        public int Quantity { get; set; } = 0; 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; 

        public CreateProductCommand(string productName, string sku, int categoryId)
        {
            ProductName = productName;
            Sku = sku;
            CategoryId = categoryId;
        }
    }
}
