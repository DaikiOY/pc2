using System;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Commands
{
    /// <summary>
    /// Command to update an existing product.
    /// </summary>
    public class UpdateProductCommand
    {
        public Guid ProductId { get; set; } 
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow; 

        // Constructor with required property
        public UpdateProductCommand(Guid productId)
        {
            ProductId = productId;
        }
    }
}
