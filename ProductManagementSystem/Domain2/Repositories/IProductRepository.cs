using ProductManagementSystem.Domain2.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagementSystem.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
        void Remove(Product product);
    }
}
