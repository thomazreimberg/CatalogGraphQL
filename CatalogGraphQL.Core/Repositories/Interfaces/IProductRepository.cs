using CatalogGraphQL.Core.Entities;

namespace CatalogGraphQL.Core.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
    }
}
