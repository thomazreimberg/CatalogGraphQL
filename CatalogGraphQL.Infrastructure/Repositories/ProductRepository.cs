﻿using CatalogGraphQL.Core.Entities;
using CatalogGraphQL.Core.Repositories.Interfaces;
using CatalogGraphQL.Infrastructure.Data.Interfaces;
using MongoDB.Driver;

namespace CatalogGraphQL.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICatalogContext catalogContext;

        public ProductRepository(ICatalogContext catalogContext)
        {
            this.catalogContext = catalogContext ?? throw new ArgumentNullException(nameof(catalogContext));
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await this.catalogContext.Products.Find(_ => true).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(string id)
        {
            var filter = Builders<Product>.Filter.Eq(_ => _.Id, id);

            return await this.catalogContext.Products.Find(filter).FirstOrDefaultAsync();
        }
    }
}
