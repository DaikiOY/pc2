using System.Collections.Generic;
using System.Threading.Tasks;
using si730pc2u20201f846.Domain.Entities;

namespace si730pc2u20201f846.Infrastructure.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int categoryId);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(Category category);
    }
}
