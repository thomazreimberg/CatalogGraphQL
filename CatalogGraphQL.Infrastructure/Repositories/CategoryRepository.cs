using CatalogGraphQL.Core.Entities;
using CatalogGraphQL.Core.Repositories.Interfaces;
using CatalogGraphQL.Infrastructure.Data.Interfaces;
using MongoDB.Driver;

namespace CatalogGraphQL.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ICatalogContext catalogContext;

        public CategoryRepository(ICatalogContext catalogContext)
        {
            this.catalogContext = catalogContext;
        }

        public async Task<Category> GetById(string id)
        {
            var filter = Builders<Category>.Filter.Eq(_ => _.Id, id);

            return await this.catalogContext.Categories.Find(filter).FirstOrDefaultAsync();
        }
    }
}
