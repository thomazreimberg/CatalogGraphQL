using CatalogGraphQL.Core.Entities;

namespace CatalogGraphQL.Core.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetById(string id);
    }
}
