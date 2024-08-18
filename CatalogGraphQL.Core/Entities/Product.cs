using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CatalogGraphQL.Core.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryId { get; set; } = string.Empty;
    }
}
