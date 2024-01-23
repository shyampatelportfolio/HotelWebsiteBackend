using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace HotelsBackend.Data
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int HotelId { get; set; }
        public int ReviewId { get; set; }
        public string? PersonName { get; set; }
        public double Rating { get; set; }
        public string? ReviewTitle { get; set; }
        public string? ReviewDescription { get; set; }
        public string? Date { get; set; }
    }
}
