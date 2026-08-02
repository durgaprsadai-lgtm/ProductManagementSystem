using ProductManagementSystem.Domain.Repositories;
using ProductManagementSystem.Infrastructure.Data;
using System;
using System.Threading.Tasks;

namespace ProductManagementSystem.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IProductRepository Products { get; }

        public UnitOfWork(AppDbContext context, IProductRepository productRepository)
        {
            _context = context;
            Products = productRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }

    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        Task<int> CompleteAsync();
    }
}