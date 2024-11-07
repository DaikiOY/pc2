using System.Collections.Generic;
using System.Threading.Tasks;
using si730pc2u20201f846.Domain.Entities;

namespace si730pc2u20201f846.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(Guid productId);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
