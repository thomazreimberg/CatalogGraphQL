using CatalogGraphQL.Core.Entities;
using CatalogGraphQL.Core.Repositories.Interfaces;
using HotChocolate;
using HotChocolate.Types;

namespace CatalogGraphQL.Resolvers
{
    [ExtendObjectType(Name = "Category")]
    public class CategoryResolver
    {
        public Task<Category> GetCategoryAsync([Parent] Product product, [Service] ICategoryRepository categoryRepository) =>
            categoryRepository.GetById(product.CategoryId);
    }
}
