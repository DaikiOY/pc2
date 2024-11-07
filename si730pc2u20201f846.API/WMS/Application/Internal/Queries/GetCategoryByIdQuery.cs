namespace si730pc2u20201f846.API.WMS.Application.Internal.Queries
{
    /// <summary>
    /// Query to retrieve a category by its unique ID.
    /// </summary>
    public class GetCategoryByIdQuery
    {
        public int CategoryId { get; set; } 

        public GetCategoryByIdQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
