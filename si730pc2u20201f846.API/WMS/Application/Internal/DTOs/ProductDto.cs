using System;

namespace si730pc2u20201f846.API.WMS.Application.Internal.DTOs
{
    /// <summary>
    /// DTO for transferring Product data.
    /// </summary>
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Sku { get; set; }
        public string CategoryName { get; set; }
        public int Status { get; set; }
        public string Location { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
