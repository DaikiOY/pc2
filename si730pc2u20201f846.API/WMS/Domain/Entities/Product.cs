using System;

namespace si730pc2u20201f846.Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; private set; } = Guid.NewGuid();
        public string ProductName { get; set; }
        public string Sku { get; set; }
        public int CategoryId { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; } = 0;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

        public Product(string productName, string sku, int categoryId, int status)
        {
            ProductName = productName;
            Sku = sku;
            CategoryId = categoryId;
            Status = status;
        }
    }
}
