using System;

namespace si730pc2u20201f846.API.WMS.Application.Internal.Queries
{
    /// <summary>
    /// Query to retrieve a product by its unique ID.
    /// </summary>
    public class GetProductByIdQuery
    {
        public Guid ProductId { get; set; }

        public GetProductByIdQuery(Guid productId)
        {
            ProductId = productId;
        }
    }
}
