using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CatalogGraphQL.Core.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string Id { get; set; }
        public required string Description { get; set; }
    }
}
