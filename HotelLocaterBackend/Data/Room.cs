using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace HotelsBackend.Data
{
    public class Room
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public ObjectId Id { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string? RoomTitle { get; set; }
        public double Rating { get; set; }
        public string? RoomDescription { get; set; }
        public double Price { get; set; }
        public List<string> Images { get; set; }
        public Details Details { get; set; }
    }

    public class Details
    {
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public int Size { get; set; }
    }
}
