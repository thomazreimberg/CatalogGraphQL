using CatalogGraphQL.Core.Entities;
using MongoDB.Driver;

namespace CatalogGraphQL.Infrastructure.Data.Interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Category> Categories { get; }
        IMongoCollection<Product> Products { get; }
    }
}
