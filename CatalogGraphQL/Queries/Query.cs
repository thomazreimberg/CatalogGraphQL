using CatalogGraphQL.Core.Entities;
using CatalogGraphQL.Core.Repositories.Interfaces;
using HotChocolate;

namespace CatalogGraphQL.Queries
{
    public class Query
    {
        public Task<IEnumerable<Product>> GetProductsAsync([Service] IProductRepository productRepository) =>
            productRepository.GetAllAsync();

        public Task<Product> GetProductById(string id, [Service] IProductRepository productRepository) =>
            productRepository.GetByIdAsync(id);
    }
}
